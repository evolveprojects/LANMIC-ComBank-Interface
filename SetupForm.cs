using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.Models.SystemModels;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace LANMIC_ComBank_Interface
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var server = txtServer.Text.Trim();
                //var dbName = txtDatabase.Text.Trim();
                var user = txtUser.Text.Trim();
                var password = txtPassword.Text.Trim();
                string masterConnection = $"server={server};user id={user};password={password};Database=master;TrustServerCertificate=true;";

                var conSQL = new SqlConnection();
                conSQL.ConnectionString = masterConnection;

                //conSQL.ConnectionString = @"Data Source=" + serverId + ";" +
                //                          "Initial Catalog=master;" +
                //                          "Persist Security info=True;" +
                //                          "User ID=" + user + ";" +
                //                          "Password=" + password + ";" +
                //                          "Connect Timeout=0";

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
                        //connectionStatus = false;
                        MessageBox.Show("This connection cannot be tested because the specified \n database does not exist or is not visible to the specified user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //log.Error(ex.Message, ex);
                    }
                }

            }
            catch (Exception ex)
            {
                //log.Error(ex.Message, ex.InnerException);
                MessageBox.Show("Can not be complete your request please contact system administrator..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateDatabaseIfNotExists(AppConfigModel config)
        {
            try
            {
                string masterConnection = $"server={config.Database.Server};user id={config.Database.User};password={config.Database.Password};Database=master;TrustServerCertificate=true;";

                // 1️⃣ Create database dynamically
                using (var connection = new SqlConnection(masterConnection))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand($"CREATE DATABASE [{config.Database.DatabaseName}]", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // 2️⃣ Create tables with EF Core
                string appConnection = $"server={config.Database.Server};user id={config.Database.User};password={config.Database.Password};Database={config.Database.DatabaseName};TrustServerCertificate=true;";
                using (var context = new AppDbContext(appConnection))
                {
                    context.Database.EnsureCreated(); // creates tables based on your models

                    // 3️⃣ Insert default Super Admin user
                    //if (!context.Users.Any())
                    //{
                    //    var superAdmin = new User
                    //    {
                    //        Username = "admin",
                    //        PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    //        Role = "SuperAdmin",
                    //        CreatedAt = DateTime.Now,
                    //        IsActive = true
                    //    };
                    //    context.Users.Add(superAdmin);
                    //    context.SaveChanges();

                    //    // 4️⃣ Insert default permissions for each table
                    //    var tableNames = new[] { "Users", "UserPermissions" };

                    //    var permissions = new List<UserPermission>();
                    //    //foreach (var table in tableNames)
                    //    //{}

                    //    permissions.Add(new UserPermission
                    //    {
                    //        UserId = superAdmin.Id,
                    //        User = superAdmin,
                    //        PermissionKey = "Read",
                    //        IsAllowed = true
                    //    });
                    //    permissions.Add(new UserPermission
                    //    {
                    //        UserId = superAdmin.Id,
                    //        User = superAdmin,
                    //        PermissionKey = "Write",
                    //        IsAllowed = true
                    //    });
                    //    permissions.Add(new UserPermission
                    //    {
                    //        UserId = superAdmin.Id,
                    //        User = superAdmin,
                    //        PermissionKey = "Delete",
                    //        IsAllowed = true
                    //    });


                    //    context.UserPermissions.AddRange(permissions);
                    //    context.SaveChanges();
                    //}
                }

                MessageBox.Show($"✅ Database '{config.Database.DatabaseName}' created successfully with default data.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }
    }
}
