using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loja_Games
{
    public partial class FimCompraNext : Form
    {
        public int pagou;
        public FimCompraNext()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento efetuado com sucesso!");
            pictureBox1.Enabled = false;
            pagou = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && pagou == 1)
            {
                MessageBox.Show("Prosseguindo para a geração da key, finalizando.");
                this.Hide();
                var end = new FimCompra1();
                end.Show();
                pagou = 0;
            }
            else
            {
                MessageBox.Show("Erro! Preencha os campos ou finalize a compra.");
            }
        }
    }
}
