using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Loja_Games
{
    static class Program
    {

        public static int dboption = 0;
        public static int iduser = 0;
        public static int lista = 0;
        public static int jgesc = 0;
        public static int isadm = 0;
        public static int islogged = 0;
        public static int idnumberac = 0;
        public static int idnumberrpg = 0;
        public static int idnumberav = 0;
        public static int idnumbertr = 0;
        public static int formapag = 0;
        public static int buy = 0;
        public static string jogo;
        public static String[] jgac = new string[9];
        public static String[] jgrpg = new string[9];
        public static String[] jgav = new string[9];
        public static String[] jgtr = new string[9];

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
