using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XML_Filler
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception exception)
            {
                ErrorCatchForm errorCatchForm = new ErrorCatchForm(exception);
                errorCatchForm.ShowDialog();
            }
        }
    }
}
