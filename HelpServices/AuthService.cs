using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
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
            using var context = new AppDbContext(_connectionString);
            await context.Database.EnsureCreatedAsync();
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
        //        using var context = new AppDbContext(_connectionString);

        //        // basic uniqueness check
        //        if (await context.UserDetails.AnyAsync(u => u.Username == username && u.IsActive == true))
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

        //        context.UserDetails.Add(user);
        //        await context.SaveChangesAsync();

        //        return (true, "Registration successful.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, "Registration failed: " + ex.Message);
        //    }
        //}

        // Login user
        // returns (success, message, user) where user is null on failure
        public async Task<(bool Success, string Message, UserDetails User)> LoginAsync(string usernameOrEmail, string password)
        {
            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                return (false, "Invalid username or password.", null);

            try
            {
                using var context = new AppDbContext(_connectionString);
                var user = await context.UserDetails
                    .FirstOrDefaultAsync(u => u.Username == usernameOrEmail && u.IsActive == true);

                if (user == null)
                    return (false, "Invalid username or password.", null);

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

                    //await context.SaveChangesAsync();
                    return (false, "Invalid username or password.", null);
                }

                //// success: reset failed count and lockout
                //user.AccessFailedCount = 0;
                //user.LockoutEnd = null;

                await context.SaveChangesAsync();

                return (true, "Login successful.", user);
            }
            catch (Exception ex)
            {
                return (false, "Login failed: " + ex.Message, null);
            }
        }
    }
}
