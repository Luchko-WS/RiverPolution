using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverPolution
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
            Application.Run(new MainForm());
        }
    }

    public static class PolutionParameters
    {
        public static double GDK;
        public static double fone;

        public static class PolutionArray
        {
            public static double[,] values = null;
            public static int width, height;
        }

    }
}
