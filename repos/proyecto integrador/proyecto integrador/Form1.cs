namespace proyecto_integrador
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Inicia la aplicación cargando el Login de protección
            Application.Run(new FormLogin());
        using System;
using System.Windows.Forms;

namespace proyecto_integrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializa configuración de la aplicación (alta DPI, estilos, etc.)
            ApplicationConfiguration.Initialize();
            // Ejecuta el formulario de login como pantalla inicial
            Application.Run(new FormLogin());
        }
    }
}
    }
}
