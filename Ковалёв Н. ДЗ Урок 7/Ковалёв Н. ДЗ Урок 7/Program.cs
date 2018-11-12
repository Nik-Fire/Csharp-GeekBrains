using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ковалёв_Н.ДЗ_Урок_7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Выбор нужной формы

            switch (2)
            {
                case 1:
                    Application.Run(new Form1());
                    break;
                case 2:
                    Application.Run(new Form2());
                    break;
            }
        }
    }
}
