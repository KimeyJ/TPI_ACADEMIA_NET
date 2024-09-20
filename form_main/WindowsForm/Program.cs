using WindowsForms;
using Domain;

namespace form_main.WindowsForm
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
            ApplicationConfiguration.Initialize();
            //AcademiaContext context = new AcademiaContext();
            //Application.Run(new form_main());
            Application.Run(new EspecialidadLista());
        }
    }
}