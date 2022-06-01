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
            var init = new FimCompra1();
            init.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var init = new ListaJogos();
            init.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
