using LANMIC_ComBank_Interface.Config;

namespace LANMIC_ComBank_Interface
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //// Check if config exists
            //if (!AppConfigService.ConfigExists())
            //{
            //    var setupForm = new SetupForm();
            //    if (setupForm.ShowDialog() != DialogResult.OK)
            //    {
            //        MessageBox.Show("Setup not completed. Application will exit.");
            //        return;
            //    }
            //}

            //// Load config
            //var config = AppConfigService.Load();


            //Application.Run(new MainForm());
            Application.Run(new LoginForm());
        }
    }
}