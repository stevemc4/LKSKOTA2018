using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Images")) Directory.CreateDirectory(Environment.CurrentDirectory + "\\Images");
            Database.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        public static int GenerateCode(string previousCode, int offset)
        {
            int temp = int.Parse(previousCode.Substring(offset));
            return ++temp;
        }
    }
}
