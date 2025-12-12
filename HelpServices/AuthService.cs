using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SessionModel;
using LANMIC_ComBank_Interface.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LANMIC_ComBank_Interface.HelpServices
{
    public class AuthService
    {
        private readonly string _connectionString;
        //private readonly int _bcryptWorkFactor = 12; // cost factor

        // Lockout policy
        //private const int MaxFailedAccess = 5;
        //private static readonly TimeSpan LockoutDuration = TimeSpan.FromMinutes(15);

        public AuthService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Ensure DB and tables exist
        public async Task EnsureDatabaseCreatedAsync()
        {
            using var db = new AppDbContext(_connectionString);
            await db.Database.EnsureCreatedAsync();
        }

        // Register user (returns success + message)
        //public async Task<(bool Success, string Message)> RegisterAsync(string username, string email, string password)
        //{
        //    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        //        return (false, "Username, email and password are required.");

        //    if (password.Length < 8)
        //        return (false, "Password must be at least 8 characters.");

        //    try
        //    {
        //        using var db = new AppDbContext(_connectionString);

        //        // basic uniqueness check
        //        if (await db.UserDetails.AnyAsync(u => u.Username == username && u.IsActive == true))
        //            return (false, "Username name already in use.");

        //       // var hash = BCrypt.Net.BCrypt.HashPassword(password, _bcryptWorkFactor);
        //        var hash = BCrypt.Net.BCrypt.HashPassword(password,12);

        //        var user = new UserDetails
        //        {
        //            Username = username,
        //            Password = hash,
        //            CreatedAt = DateTime.UtcNow,
        //            IsActive = true
        //        };

        //        db.UserDetails.Add(user);
        //        await db.SaveChangesAsync();

        //        return (true, "Registration successful.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, "Registration failed: " + ex.Message);
        //    }
        //}

        // Login user
        // returns (success, message, user) where user is null on failure
        public async Task<(bool Success, string Message)> LoginAsync(string usernameOrEmail, string password)
        {           
            UserSession.Clear();
            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {     
                return (false, "Invalid username or password.");
            }               


            try
            {
                using var db = new AppDbContext(_connectionString);
                var user = await db.UserDetails
                    .FirstOrDefaultAsync(u => u.Username == usernameOrEmail && u.IsActive == true);

                if (user == null)
                {
                
                    return (false, "Invalid username or password.");
                }

                // check lockout
                //if (user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.UtcNow)
                //{
                //    return (false, $"Account locked until {user.LockoutEnd.Value:u}", null);
                //}

                // verify password
                bool ok = BCrypt.Net.BCrypt.Verify(password, user.Password);

                if (!ok)
                {
                    //// increment failed attempts
                    //user.AccessFailedCount++;
                    //if (user.AccessFailedCount >= MaxFailedAccess)
                    //{
                    //    user.LockoutEnd = DateTime.UtcNow.Add(LockoutDuration);
                    //    user.AccessFailedCount = 0; // reset after locking
                    //}

                    //await db.SaveChangesAsync();
              
                    return (false, "Invalid username or password.");
                }
               
                var permissions = await (from ua in db.UserAuthorities
                                         join f in db.FormDetails on ua.FormID equals f.FormID
                                         where ua.UserID == user.ID
                    select new UserAuthorityViewModel
                    {
                        ID = ua.ID,
                        PermissionID = ua.PermissionID,
                        FormID = ua.FormID,
                        FormName = f.FormName,
                        FormDescription = f.FormDescription,
                        UserID = ua.UserID,
                        CreatedAt = ua.CreatedAt,
                        View = PermissionUtilities.Decode(ua.PermissionID).View,
                        New = PermissionUtilities.Decode(ua.PermissionID).New,
                        Edit = PermissionUtilities.Decode(ua.PermissionID).Edit,
                        Delete = PermissionUtilities.Decode(ua.PermissionID).Delete,
                        Print = PermissionUtilities.Decode(ua.PermissionID).Print
                    }).ToListAsync();

                UserSession.UserID = user.ID;
                UserSession.Username = user.Username;
                UserSession.UserPermissions = permissions;
                         //   UserSession.IsAdmin = permissions.Any(p => p. == "Admin");
                UserSession.LoginTime = DateTime.UtcNow;



                //// success: reset failed count and lockout
                //user.AccessFailedCount = 0;
                //user.LockoutEnd = null;
                //await db.SaveChangesAsync();

                return (true, "Login successful.");
            }
            catch (Exception ex)
            {
                UserSession.Clear();
                return (false, "Login failed: " + ex.Message);
            }
        }
    }
}
