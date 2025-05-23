using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using CompanionFormApp.PrimaryForms;

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

            IProcessManager processManager = new ProcessManager();
            IProjectManager projectManager = new JsonProjectManager();

            ApplicationConfiguration.Initialize();

            Application.Run(new GitWrapperForm(processManager, projectManager));
        }
    }
}