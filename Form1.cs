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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cad = new Cadastro();
            cad.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var mod = new dbadm();
            mod.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 1;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 2;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 4;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.lista = 3;
            this.Hide();
            var ac = new ListaJogos();
            ac.Show();
        }
    }
}
