using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SystemModels;
using log4net;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace LANMIC_ComBank_Interface
{
    public partial class SetupForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public SetupForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var server = txtServer.Text.Trim();
            //var dbName = txtDatabase.Text.Trim();
            var user = txtUser.Text.Trim();
            var password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields (Server, User, Password).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string masterConnection = $"server={server};" +
                                      $"user id={user};" +
                                      $"password={password};" +
                                      $"Database=master;TrustServerCertificate=true;";

            var conSQL = new SqlConnection();
            conSQL.ConnectionString = masterConnection;
            if (conSQL.State == ConnectionState.Closed)
            {
                try
                {
                    conSQL.Open();
                    if (conSQL.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Test Connection Succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //connectionStatus = true;
                        conSQL.Close();
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message, ex.InnerException);
                    MessageBox.Show("This connection cannot be tested because the specified \n database does not exist or is not visible to the specified user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = new DatabaseConfigModel
            {                 
                    AppName = txtAppName.Text.Trim(),
                    Server = txtServer.Text.Trim(),
                    DatabaseName = txtDatabase.Text.Trim(),
                    User = txtUser.Text.Trim(),
                    Password = txtPassword.Text.Trim() 
            };

            // Save config to appsettings.json
            AppConfigService.Save(config);

            // Create database and tables if not exists
            bool status = CreateDatabaseIfNotExists(config);

            if (!status)
            {
               AppConfigService.Delete();
               MessageBox.Show("Failed to create database and tables. Please check the logs for more details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Configuration saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    
    
        private bool CreateDatabaseIfNotExists(DatabaseConfigModel config)
        {
            string masterConnection = $"server={config.Server};" +
                                      $"user id={config.User};" +
                                      $"password={config.Password};" +
                                      $"Database=master;TrustServerCertificate=true;";

            bool isDbCreated = false;
            bool isTablesCreated = false;
            bool isDefaultDataInserted = false;
            bool isDeleted = false;
            bool status = false;

            try
            {
                // 1️⃣ Create database dynamically
                using (var connection = new SqlConnection(masterConnection))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand($"CREATE DATABASE [{config.DatabaseName}]", connection))
                    {
                        cmd.ExecuteNonQuery();
                        isDbCreated = true;
                        log.Info($"Database '{config.DatabaseName}' created successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                isDbCreated = false;
                log.Error(ex.Message, ex.InnerException);
            }

                // 2️⃣ Create tables with EF Core
            if (isDbCreated)
            {
               
                string appConnection = $"server={config.Server};" +
                                       $"user id={config.User};" +
                                       $"password={config.Password};" +
                                       $"Database={config.DatabaseName};TrustServerCertificate=true;";

                using (var context = new AppDbContext(appConnection))
                {
                    isTablesCreated = context.Database.EnsureCreated(); // creates tables based on your models
                   
                    if (isTablesCreated)
                    {  
                        log.Info("Database tables created successfully.");
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                if (!context.UserDetails.Any())
                                {
                                    var superAdmin = new UserDetails
                                    {
                                        Username = "admin",
                                        Password = BCrypt.Net.BCrypt.HashPassword("admin123",12),
                                        CreatedAt = DateTime.Now,
                                        IsActive = true
                                    };
                                    context.UserDetails.Add(superAdmin);
                                    context.SaveChanges();

                                    //List<FormDetails> defaultForms = new List<FormDetails>
                                    //{
                                    //    new FormDetails { FormID = "Form1", FormName = "frmUserCreation", FormDescription = "User Creation" },
                                    //    new FormDetails { FormID = "Form2", FormName = "frmUserAuthorization", FormDescription = "User Authorization" },
                                    //    new FormDetails { FormID = "Form3", FormName = "frmVendors", FormDescription = "Vendors" },
                                    //    new FormDetails { FormID = "Form3", FormName = "frmBanks", FormDescription = "Vendor Banks" }
                                    //};

                                    transaction.Commit();
                                    isDefaultDataInserted = true;
                                    log.Info("Default data inserted successfully.");
                                }
                            }
                            catch (Exception ex)
                            {                                
                                log.Error(ex.Message, ex.InnerException);                      
                                isDefaultDataInserted = false;
                                transaction.Rollback();
                            }
                        }
                    }
                    else
                    {
                        isTablesCreated = false;
                        log.Error("Failed to create database tables.");
                    }
                }
            }

            if (isDbCreated == true && isTablesCreated == false || isDefaultDataInserted == false)
            {
                try
                {
                    // 3 Delete database dynamically
                    using (var connection = new SqlConnection(masterConnection))
                    {
                        connection.Open();
                        using (var cmd = new SqlCommand($"DROP DATABASE [{config.DatabaseName}]", connection))
                        {
                            cmd.ExecuteNonQuery();
                            isDeleted = true;
                            isDbCreated = false;
                            log.Info($"Database '{config.DatabaseName}' deleted successfully due to errors during setup.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message, ex.InnerException);
                }
            }
           
            if(isDbCreated && isTablesCreated && isDefaultDataInserted)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

    
    }
}
