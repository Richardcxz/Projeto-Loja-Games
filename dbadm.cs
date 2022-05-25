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
    public partial class dbadm : Form
    {
        MySqlConnection conexao10;
        MySqlDataAdapter da;
        MySqlCommand comando;
        public string sql;
        public dbadm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";

            conexao10 = new MySqlConnection(data_source);

            if (Projeto_Loja_Games.Program.dboption == 1)
            {
                MessageBox.Show("variável vale 1");
            }
            else if (Projeto_Loja_Games.Program.dboption == 2)
            {
                MessageBox.Show("variável vale 2");
            }
            else if (Projeto_Loja_Games.Program.dboption == 3)
            {
                MessageBox.Show("variável vale 3");
            }
            if (Projeto_Loja_Games.Program.dboption == 4)
            {
                MessageBox.Show("variável vale 4");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") {
                switch (Projeto_Loja_Games.Program.dboption) {
                    case 1:
                        sql = "INSERT INTO cad_acao (nome_acao, descricao_acao, ano_acao, avaliacao_acao) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                        comando = new MySqlCommand(sql, conexao10);

                        conexao10.Open();
                        comando.ExecuteReader();

                        MessageBox.Show("Jogo de ação inserido com sucesso!");

                        conexao10.Close();
                        break;

                    case 2:
                        sql = "INSERT INTO cad_rpg (nome_rpg, descricao_rpg, ano_rpg, avaliacao_rpg) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                        comando = new MySqlCommand(sql, conexao10);

                        conexao10.Open();
                        comando.ExecuteReader();

                        MessageBox.Show("Jogo de rpg inserido com sucesso!");

                        conexao10.Close();
                        break;

                    case 3:
                        sql = "INSERT INTO cad_aventura (nome_aventura, descricao_aventura, ano_aventura, avaliacao_aventura) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                        comando = new MySqlCommand(sql, conexao10);

                        conexao10.Open();
                        comando.ExecuteReader();

                        MessageBox.Show("Jogo de aventura inserido com sucesso!");

                        conexao10.Close();
                        break;

                    case 4:
                        sql = "INSERT INTO cad_terror (nome_terror, descricao_terror, ano_terror, avaliacao_terror) " +
                            "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                        comando = new MySqlCommand(sql, conexao10);

                        conexao10.Open();
                        comando.ExecuteReader();

                        MessageBox.Show("Jogo de terror inserido com sucesso!");

                        conexao10.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio!");
        }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var alt = new alteracoesadm();
            alt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";

            conexao10 = new MySqlConnection(data_source);

            string sql = "SELECT * FROM cad_cliente";

            da = new MySqlDataAdapter(sql,conexao10);

            DataTable DT = new DataTable();

            da.Fill(DT);

            dataGridView1.DataSource = DT;

        }
    }
}
