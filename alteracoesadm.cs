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
            this.Hide();
            var ac = new dbacao();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ac = new dbrpg();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ac = new dbaventura();
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ac = new dbterror();
            ac.Show();
        }
    }
}
