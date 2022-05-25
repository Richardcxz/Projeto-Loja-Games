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
    public partial class Form1log : Form
    {
        public Form1log()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 1;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 2;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 3;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 4;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mn = new Form1();
            mn.Show();
        }
    }
}
