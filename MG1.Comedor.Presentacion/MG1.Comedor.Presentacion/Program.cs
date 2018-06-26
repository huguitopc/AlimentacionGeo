using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG1.Comedor.Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmProgramacion());
            //Application.Run(new FrmReportes());
            //Application.Run(new FrmLogin());
            Application.Run(new FrmMaimMenu());
        }
    }
}
