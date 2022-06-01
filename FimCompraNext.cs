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
    public partial class FimCompraNext : Form
    {
        public FimCompraNext()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if(Program.formapag == 1)
            {
                button2.Text = "PAGAR COM BOLETO";
            }
            else if (Program.formapag == 2)
            {
                button2.Text = "PAGAR COM PICPAY";
            }
            else if (Program.formapag == 3)
            {
                button2.Text = "PAGAR COM PAYPAL";
            }
            else if (Program.formapag == 4)
            {
                button2.Text = "PAGAR COM PIX";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Prosseguindo para a geração da key, finalizando.");
                this.Hide();
                var end = new FimCompra1();
                end.Show();
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento efetuado com sucesso!");
            button2.Enabled = false;
        }
    }
}
