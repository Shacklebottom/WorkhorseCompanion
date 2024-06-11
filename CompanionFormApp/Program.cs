using CompanionBusiness;
using CompanionFormApp.primaryForm;

namespace CompanionFormApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            IProcessManager manager = new ProcessManager();

            ApplicationConfiguration.Initialize();
            Application.Run(new GitWrapperForm(manager));
        }
    }
}