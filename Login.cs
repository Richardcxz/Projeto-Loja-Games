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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public int adm1 = 0;
        public int adm2 = 0;
        public int txt1 = 0;
        public int txt2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(adm1 == 1 && adm2 == 1)
            {
                MessageBox.Show("Admin detectado.");
                this.Hide();
                var menuadm = new Form1adm();
                menuadm.Show();
            }
            else if(txt1 == 1 && txt2 == 1)
            {
                this.Hide();
                var menulog = new Form1log();
                menulog.Show();
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                adm1 = 1;
            }

            else
            {
                txt1 = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                adm2 = 1;
            }

            else
            {
                txt2 = 1;
            }
        }
    }
}
