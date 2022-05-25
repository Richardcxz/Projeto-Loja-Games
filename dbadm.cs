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
        DataTable DT;
        public dbadm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";

            conexao10 = new MySqlConnection(data_source);
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
            switch (Projeto_Loja_Games.Program.dboption) { 

            case 1:
            sql = "SELECT * FROM cad_acao";
            da = new MySqlDataAdapter(sql,conexao10);
            DT = new DataTable();
            da.Fill(DT);
            dataGridView1.DataSource = DT;

                break;
            case 2:
            sql = "SELECT * FROM cad_rpg";
            da = new MySqlDataAdapter(sql, conexao10);
            DT = new DataTable();
            da.Fill(DT);
            dataGridView1.DataSource = DT;

                break;
            case 3:
            sql = "SELECT * FROM cad_aventura";
            da = new MySqlDataAdapter(sql, conexao10);
            DT = new DataTable();
            da.Fill(DT);
            dataGridView1.DataSource = DT;

                break;
            case 4:
            sql = "SELECT * FROM cad_terror";
            da = new MySqlDataAdapter(sql, conexao10);
            DT = new DataTable();
            da.Fill(DT);
            dataGridView1.DataSource = DT;

                break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (Projeto_Loja_Games.Program.dboption)
            {

            case 1:
            sql = "DELETE FROM cad_acao WHERE nome_acao = @nomeac";
            comando = new MySqlCommand(sql, conexao10);
            comando.Parameters.AddWithValue("@nomeac", textBox1.Text);
            conexao10.Open();
            comando.ExecuteReader();
            MessageBox.Show("Jogo de ação deletado com sucesso!");
            conexao10.Close();
            break;

            case 2:
            sql = "DELETE FROM cad_rpg WHERE nome_rpg = @nomerpg";
            comando = new MySqlCommand(sql, conexao10);
            comando.Parameters.AddWithValue("@nomerpg", textBox1.Text);
            conexao10.Open();
            comando.ExecuteReader();
            MessageBox.Show("Jogo de rpg deletado com sucesso!");
            conexao10.Close();
            break;

            case 3:
            sql = "DELETE FROM cad_aventura WHERE nome_aventura = @nomeaventura";
            comando = new MySqlCommand(sql, conexao10);
            comando.Parameters.AddWithValue("@nomeaventura", textBox1.Text);
            conexao10.Open();
            comando.ExecuteReader();
            MessageBox.Show("Jogo de aventura deletado com sucesso!");
            conexao10.Close();
            break;

            case 4:
            sql = "DELETE FROM cad_terror WHERE nome_terror = @nometerror";
            comando = new MySqlCommand(sql, conexao10);
            comando.Parameters.AddWithValue("@nometerror", textBox1.Text);
            conexao10.Open();
            comando.ExecuteReader();
            MessageBox.Show("Jogo de terror deletado com sucesso!");
            conexao10.Close();
            break;

            }
        }
    }
}
