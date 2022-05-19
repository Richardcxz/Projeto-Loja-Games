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
    public partial class Form1adm : Form
    {
        public Form1adm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ac = new Action();
            ac.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rpg = new rpg();
            rpg.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var av = new aventura();
            av.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ter = new terror();
            ter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var altadm = new alteracoesadm();
            altadm.Show();
        }
    }
}
