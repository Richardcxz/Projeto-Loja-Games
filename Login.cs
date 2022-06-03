using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Loja_Games
{
    public partial class Login : Form
    {
        MySqlConnection conexao;
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var init = new Form1();
            init.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (adm1 == 1 && adm2 == 1)
            {
                Projeto_Loja_Games.Program.isadm = 1;
                Projeto_Loja_Games.Program.buy = 1;
                MessageBox.Show("Admin detectado.");
                this.Hide();
                var menuadm = new Form1adm();
                menuadm.Show();
            }
            else if (txt1 == 1 && txt2 == 1)
            {
                string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";

                conexao = new MySqlConnection(data_source);

                string sql = $"SELECT * FROM cad_cliente WHERE nome='{textBox1.Text}' AND senha='{textBox2.Text}';";

                MySqlCommand cmnd = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader reader = cmnd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    conexao.Close();
                    Projeto_Loja_Games.Program.islogged = 1;
                    Projeto_Loja_Games.Program.buy = 1;
                    MessageBox.Show("Login Realizado.");
                    this.Hide();
                    var menulog = new Form1log();
                    menulog.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretas!");
                }
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio!");
            }
        }
    }
}
