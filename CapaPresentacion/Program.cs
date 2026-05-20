using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Presentation;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Video 14: Cambio de formulario que se va a ejecutar al iniciar el programa, del frmInicio al frmLogin
            Application.Run(new Login());
        }
    }
}
