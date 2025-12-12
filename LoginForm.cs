using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.HelpServices;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using log4net;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static System.Collections.Specialized.BitVector32;

namespace LANMIC_ComBank_Interface
{
    public partial class LoginForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(AppConfigService.ConnectionString());
            _ = InitializeDatabaseAsync();

           txtUsername.Text="admin";
           txtPassword.Text="admin123";
            SignIn();
        }

        private async Task InitializeDatabaseAsync()
        {
            try
            {
                await _authService.EnsureDatabaseCreatedAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();

            //if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) // Example validation
            //{               
            //    using (AppDbContext db = new AppDbContext(AppConfigService.ConnectionString()))
            //    {
            //        try
            //        {
            //            UserDetails user =  db.UserDetails.FirstOrDefault(u => u.Username == username);

            //            if (user != null)
            //            {
            //                // verify password
            //                bool ok = BCrypt.Net.BCrypt.Verify(password, user.Password);

            //                if (!ok)
            //                {
            //                    log.Warn($"Failed login attempt for user '{username}'.");
            //                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                {
            //                    MainForm mainForm = new MainForm();
            //                    mainForm.Show();
            //                    this.Hide();
            //                }
            //            }
            //            else
            //            {
            //                log.Warn($"Failed login attempt for user '{username}'.");
            //                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        catch (Exception ex)
            //        { 
            //            log.Error("Error during login process.", ex);
            //            MessageBox.Show("An error occurred during login. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }               
            //}
            //else
            //{
            //    log.Warn($"Failed login attempt for user '{username}'.");
            //    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private async void SignIn()
        {
            btnSignIn.Enabled = false;
            //lblStatus.Text = "Logging in...";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var (Success, Message) = await _authService.LoginAsync(username, password);

            //lblStatus.Text = Message;
            btnSignIn.Enabled = true;

            if (Success)
            {
                // set current session (simple static holder)
                // Session.CurrentUser = User;

                // open main form
                var main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                log.Warn($"Failed login attempt for user '{username}'.");
                MessageBox.Show(Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
                {
                    SignIn();
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus();
                }
            }
        }


    }
}
