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
    public partial class FimCompra1 : Form
    {
        public string codea = "";
        public string codeb = "";
        public string codec = "";
        public string codefinal = "";
        public FimCompra1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lista = new ListaJogos();
            lista.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int x = 1; x <= 1; x++)
            {
                codea = Convert.ToString(rnd.Next(10000,99999));
            }
            for (int x = 1; x <= 1; x++)
            {
                codeb = Convert.ToString(rnd.Next(10000, 99999));
            }
            for (int x = 1; x <= 1; x++)
            {
                codec = Convert.ToString(rnd.Next(10000, 99999));
            }

            codefinal = codea + "-" + codeb + "-" + codec;
            label3.Text = codefinal;

            pictureBox2.Enabled = false;

        }
    }
}
