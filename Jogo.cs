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
    public partial class Jogo : Form
    {
        MySqlConnection conexao;
        MySqlConnection conexao2;
        MySqlCommand cmnd;
        MySqlDataReader dr;
        MySqlDataReader pegarnome;
        MySqlDataReader pegarlastid;
        public string sql;
        public int sqlidi1;
        public int sqlidi2;
        public int sqlidi3;
        public int sqlidi4;
        string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
        public Jogo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            conexao = new MySqlConnection(data_source);
            conexao.Open();

            if (Program.lista == 1)
            {
                sql = "SELECT nome_acao FROM cad_acao WHERE id = "+Program.jgesc+";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                string jogoac1 = pegarnome["nome_acao"].ToString();
                label1.Text = jogoac1;
                pegarnome.Close();

                sql = "SELECT ano_acao FROM cad_acao WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoac1 = pegarnome["ano_acao"].ToString();
                label6.Text = jogoac1;
                pegarnome.Close();

                sql = "SELECT avaliacao_acao FROM cad_acao WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoac1 = pegarnome["avaliacao_acao"].ToString();
                label7.Text = jogoac1;
                pegarnome.Close();

                sql = "SELECT descricao_acao FROM cad_acao WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoac1 = pegarnome["descricao_acao"].ToString();
                label4.Text = jogoac1;
                pegarnome.Close();
            }

            if (Program.lista == 2)
            {
                sql = "SELECT nome_rpg FROM cad_rpg WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                string jogorpg1 = pegarnome["nome_rpg"].ToString();
                label1.Text = jogorpg1;
                pegarnome.Close();

                sql = "SELECT ano_rpg FROM cad_rpg WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogorpg1 = pegarnome["ano_rpg"].ToString();
                label6.Text = jogorpg1;
                pegarnome.Close();

                sql = "SELECT avaliacao_rpg FROM cad_rpg WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogorpg1 = pegarnome["avaliacao_rpg"].ToString();
                label7.Text = jogorpg1;
                pegarnome.Close();

                sql = "SELECT descricao_rpg FROM cad_rpg WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogorpg1 = pegarnome["descricao_rpg"].ToString();
                label4.Text = jogorpg1;
                pegarnome.Close();
            }

            if (Program.lista == 3)
            {
                sql = "SELECT nome_aventura FROM cad_aventura WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                string jogoav1 = pegarnome["nome_aventura"].ToString();
                label1.Text = jogoav1;
                pegarnome.Close();

                sql = "SELECT ano_aventura FROM cad_aventura WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoav1 = pegarnome["ano_aventura"].ToString();
                label6.Text = jogoav1;
                pegarnome.Close();

                sql = "SELECT avaliacao_aventura FROM cad_aventura WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoav1 = pegarnome["avaliacao_aventura"].ToString();
                label7.Text = jogoav1;
                pegarnome.Close();

                sql = "SELECT descricao_aventura FROM cad_aventura WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoav1 = pegarnome["descricao_aventura"].ToString();
                label4.Text = jogoav1;
                pegarnome.Close();
            }

            if (Program.lista == 4)
            {
                sql = "SELECT nome_terror FROM cad_terror WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                string jogotr1 = pegarnome["nome_terror"].ToString();
                label1.Text = jogotr1;
                pegarnome.Close();

                sql = "SELECT ano_terror FROM cad_terror WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogotr1 = pegarnome["ano_terror"].ToString();
                label6.Text = jogotr1;
                pegarnome.Close();

                sql = "SELECT avaliacao_terror FROM cad_terror WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogotr1 = pegarnome["avaliacao_terror"].ToString();
                label7.Text = jogotr1;
                pegarnome.Close();

                sql = "SELECT descricao_terror FROM cad_terror WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogotr1 = pegarnome["descricao_terror"].ToString();
                label4.Text = jogotr1;
                pegarnome.Close();
            }


            conexao.Close();


        }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                var lst = new ListaJogos();
                lst.Show();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.buy == 0)
            {
            MessageBox.Show("Crie uma conta para comprar!");
            }
            else { 
            this.Hide();
            var compra = new FimCompra();
            compra.Show();
            }
        }
    }
    }
