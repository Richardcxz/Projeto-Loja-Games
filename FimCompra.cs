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
    public partial class FimCompra : Form
    {
        public FimCompra()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var init = new FimCompraNext();
            init.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        if(comboBox1.SelectedIndex == 1)
            {
                Program.formapag = 1;
            }
        else if (comboBox1.SelectedIndex == 2)
            {
                Program.formapag = 2;
            }
        else if (comboBox1.SelectedIndex == 3)
            {
                Program.formapag = 3;
            }
        else if (comboBox1.SelectedIndex == 4)
            {
                Program.formapag = 4;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Cancelada!");
            this.Hide();
            var init = new ListaJogos();
            init.Show();
        }
    }
}
