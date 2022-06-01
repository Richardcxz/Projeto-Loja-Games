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
        MySqlDataReader pegarlastid;
        MySqlDataReader pegarlastid2;
        MySqlDataReader pegarlastid3;
        MySqlDataReader pegarlastid4;
        public string sql;
        public int idcheck;
        public int sqlidi1;
        public int sqlidi2;
        public int sqlidi3;
        public int sqlidi4;
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
            if (checkBox1.Checked == true)
            {
                idcheck = 1;
            }
            else
            {
                idcheck = 0;
            }

            if (textBox1.Text != "" && textBox2.Text != "") {

                conexao10.Close();

                switch (Projeto_Loja_Games.Program.dboption) {
                    case 1:

                        if (idcheck == 0)
                        {
                            conexao10.Open();

                            string sqlid1 = "SELECT ID FROM cad_acao where ID =(Select Max(ID) from cad_acao);";
                            MySqlCommand cmnd1 = new MySqlCommand(sqlid1, conexao10);
                            pegarlastid = cmnd1.ExecuteReader();
                            pegarlastid.Read();
                            string strlastid1 = pegarlastid["ID"].ToString();
                            sqlidi1 = Int32.Parse(strlastid1);

                            conexao10.Close();
                        }

                        if (sqlidi1 < 8)
                        {
                            sql = "INSERT INTO cad_acao (id, nome_acao, descricao_acao, ano_acao, avaliacao_acao) " +
                                "VALUES ('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                            comando = new MySqlCommand(sql, conexao10);

                            conexao10.Open();
                            comando.ExecuteReader();

                            MessageBox.Show("Jogo de ação inserido com sucesso!");

                            conexao10.Close();
                            //---------------------------------------------------------

                        }
                        else if (sqlidi1 == 8)
                        {
                            MessageBox.Show("A tabela já possui 8 jogos da categoria!");
                        }
                        break;

                    case 2:

                        if (idcheck == 0) {
                        conexao10.Open();

                        string sqlid2 = "SELECT ID FROM cad_rpg where ID =(Select Max(ID) from cad_rpg);";
                        MySqlCommand cmnd2 = new MySqlCommand(sqlid2, conexao10);
                        pegarlastid2 = cmnd2.ExecuteReader();
                        pegarlastid2.Read();
                        string strlastid2 = pegarlastid2["ID"].ToString();
                        sqlidi2 = Int32.Parse(strlastid2);

                            conexao10.Close();
                        }

                        if (sqlidi2 < 8)
                        {
                            sql = "INSERT INTO cad_rpg (id, nome_rpg, descricao_rpg, ano_rpg, avaliacao_rpg) " +
                                "VALUES ('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                            comando = new MySqlCommand(sql, conexao10);

                            conexao10.Open();
                            comando.ExecuteReader();

                            MessageBox.Show("Jogo de rpg inserido com sucesso!");

                            conexao10.Close();
                        }
                        else if (sqlidi2 == 8)
                        {
                            MessageBox.Show("A tabela já possui 8 jogos da categoria!");
                        }
                        break;

                    case 3:

                        if (idcheck == 0)
                        {
                            conexao10.Open();

                            string sqlid3 = "SELECT ID FROM cad_aventura where ID =(Select Max(ID) from cad_aventura);";
                            MySqlCommand cmnd3 = new MySqlCommand(sqlid3, conexao10);
                            pegarlastid3 = cmnd3.ExecuteReader();
                            pegarlastid3.Read();
                            string strlastid3 = pegarlastid3["ID"].ToString();
                            sqlidi3 = Int32.Parse(strlastid3);

                            conexao10.Close();
                        }

                        if (sqlidi3 < 8)
                        {
                            sql = "INSERT INTO cad_aventura (id, nome_aventura, descricao_aventura, ano_aventura, avaliacao_aventura) " +
                            "VALUES ('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                            comando = new MySqlCommand(sql, conexao10);

                            conexao10.Open();
                            comando.ExecuteReader();

                            MessageBox.Show("Jogo de aventura inserido com sucesso!");

                            conexao10.Close();
                        }
                        else if (sqlidi3 == 8)
                        {
                            MessageBox.Show("A tabela já possui 8 jogos da categoria!");
                        }
                        break;

                    case 4:

                        if (idcheck == 0)
                        {
                            conexao10.Open();

                            string sqlid4 = "SELECT ID FROM cad_terror where ID =(Select Max(ID) from cad_terror);";
                            MySqlCommand cmnd4 = new MySqlCommand(sqlid4, conexao10);
                            pegarlastid4 = cmnd4.ExecuteReader();
                            pegarlastid4.Read();
                            string strlastid4 = pegarlastid4["ID"].ToString();
                            sqlidi4 = Int32.Parse(strlastid4);

                            conexao10.Close();
                        }

                        if (sqlidi4 < 8) {
                            sql = "INSERT INTO cad_terror (id, nome_terror, descricao_terror, ano_terror, avaliacao_terror) " +
                                "VALUES ('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";

                            comando = new MySqlCommand(sql, conexao10);

                            conexao10.Open();
                            comando.ExecuteReader();

                            MessageBox.Show("Jogo de terror inserido com sucesso!");

                            conexao10.Close();
                        }
                        else if (sqlidi4 == 8)
                        {
                            MessageBox.Show("A tabela já possui 8 jogos da categoria!");
                        }
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
