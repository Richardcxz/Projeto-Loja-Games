using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loja_Games
{
    public partial class alteracoesadm : Form
    {
        public alteracoesadm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.dboption = 1;
            this.Hide();
            var ac = new dbadm();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.dboption = 2;
            this.Hide();
            var ac = new dbadm();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.dboption = 3;
            this.Hide();
            var ac = new dbadm();
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.dboption = 4;
            this.Hide();
            var ac = new dbadm();
            ac.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mnadm = new Form1adm();
            mnadm.Show();
        }
    }
}
