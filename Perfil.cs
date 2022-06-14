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
    public partial class Perfil : Form
    {
        public int escolhadb;
        MySqlConnection conexao;
        MySqlDataReader dr;
        public Perfil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            label4.Hide();
            textBox1.Hide();
            pictureBox3.Hide();
            label2.Hide();
            listBox1.Hide();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            escolhadb = 1;
            label4.Text = "MUDAR LOGIN";

            label4.Show();
            textBox1.Show();
            pictureBox3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            escolhadb = 2;
            label4.Text = "MUDAR SENHA";

            label4.Show();
            textBox1.Show();
            pictureBox3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           if(escolhadb == 1)
            {
                if (textBox1.Text != "")
                {
                    

                    string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
                    conexao = new MySqlConnection(data_source);

                    string sql = "UPDATE cad_cliente SET nome = @NOME WHERE id = @ID";

                    MySqlCommand cmnd = new MySqlCommand(sql, conexao);
                    cmnd.Parameters.AddWithValue("@ID", Program.iduser);
                    cmnd.Parameters.AddWithValue("@NOME", textBox1.Text);

                    conexao.Open();

                    cmnd.ExecuteNonQuery();

                    conexao.Close();

                    MessageBox.Show("Informação alterada com sucesso!");
                }
                else
                {
                    MessageBox.Show("O campo de texto está vazio.");
                }
            }
           else if(escolhadb == 2)
            {
                if (textBox1.Text != "")
                {

                    string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
                    conexao = new MySqlConnection(data_source);

                    string sql = "UPDATE cad_cliente SET senha = @SENHA WHERE id = @ID";

                    MySqlCommand cmnd = new MySqlCommand(sql, conexao);
                    cmnd.Parameters.AddWithValue("@ID", Program.iduser);
                    cmnd.Parameters.AddWithValue("@SENHA", textBox1.Text);

                    conexao.Open();

                    cmnd.ExecuteNonQuery();

                    conexao.Close();

                    MessageBox.Show("Informação alterada com sucesso!");

                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("O campo de texto está vazio.");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mn = new Form1log();
            mn.Show();
        }
    }
}
