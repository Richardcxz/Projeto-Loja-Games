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
        public string jogoac1;
        public string jogorpg1;
        public string jogoav1;
        public string jogotr1;
        public string jogoac1n;
        public string jogorpg1n;
        public string jogoav1n;
        public string jogotr1n;
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
                string sqlid1 = "SELECT ID FROM cad_acao where ID =(Select Max(ID) from cad_acao);";
                MySqlCommand cmnd1 = new MySqlCommand(sqlid1, conexao);
                pegarlastid = cmnd1.ExecuteReader();
                pegarlastid.Read();
                string strlastid1 = pegarlastid["ID"].ToString();
                sqlidi1 = Int32.Parse(strlastid1);
                Program.idnumberac = sqlidi1;
                pegarlastid.Close();
            }

            if (Program.lista == 2)
            {
                string sqlid2 = "SELECT ID FROM cad_rpg where ID =(Select Max(ID) from cad_rpg);";
                MySqlCommand cmnd2 = new MySqlCommand(sqlid2, conexao);
                pegarlastid = cmnd2.ExecuteReader();
                pegarlastid.Read();
                string strlastid2 = pegarlastid["ID"].ToString();
                sqlidi2 = Int32.Parse(strlastid2);
                Program.idnumberrpg = sqlidi2;
                pegarlastid.Close();
            }

            if (Program.lista == 3)
            {
                string sqlid3 = "SELECT ID FROM cad_aventura where ID =(Select Max(ID) from cad_aventura);";
                MySqlCommand cmnd3 = new MySqlCommand(sqlid3, conexao);
                pegarlastid = cmnd3.ExecuteReader();
                pegarlastid.Read();
                string strlastid3 = pegarlastid["ID"].ToString();
                sqlidi3 = Int32.Parse(strlastid3);
                Program.idnumberav = sqlidi3;
                pegarlastid.Close();
            }

            if (Program.lista == 4)
            {
                string sqlid4 = "SELECT ID FROM cad_terror where ID =(Select Max(ID) from cad_terror);";
                MySqlCommand cmnd4 = new MySqlCommand(sqlid4, conexao);
                pegarlastid = cmnd4.ExecuteReader();
                pegarlastid.Read();
                string strlastid4 = pegarlastid["ID"].ToString();
                sqlidi4 = Int32.Parse(strlastid4);
                Program.idnumbertr = sqlidi4;
                pegarlastid.Close();
            }


            if (Program.lista == 1)
            {

                {
                    for (int x = 1; x <= sqlidi1; x++)
                    {
                        if (Program.jgesc == 1)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 2)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 3)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 4)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 5)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 6)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 7)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }
                        else if (Program.jgesc == 8)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\ac\" + Program.jgac[x] + ".jpg";
                        }

                    }
                }


                sql = "SELECT nome_acao FROM cad_acao WHERE id = "+Program.jgesc+";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoac1n = pegarnome["nome_acao"].ToString();
                label1.Text = jogoac1n;
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

                    for (int x = 1; x <= sqlidi2; x++)
                    {
                        if (Program.jgesc == 1)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 2)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 3)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 4)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 5)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 6)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 7)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                        else if (Program.jgesc == 8)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\rpg\" + Program.jgrpg[x] + ".jpg";
                        }
                }

                sql = "SELECT nome_rpg FROM cad_rpg WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogorpg1n = pegarnome["nome_rpg"].ToString();
                label1.Text = jogorpg1n;
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
                
                for (int x = 1; x <= sqlidi3; x++)
                    {
                        if (Program.jgesc == 1)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 2)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 3)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 4)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 5)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 6)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 7)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }
                        else if (Program.jgesc == 8)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\av\" + Program.jgav[x] + ".jpg";
                        }

                    }

                sql = "SELECT nome_aventura FROM cad_aventura WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogoav1n = pegarnome["nome_aventura"].ToString();
                label1.Text = jogoav1n;
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

                for (int x = 1; x <= sqlidi4; x++)
                    {
                        if (Program.jgesc == 1)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 2)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 3)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 4)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 5)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 6)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 7)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }
                        else if (Program.jgesc == 8)
                        {
                            pictureBox1.ImageLocation = @"C:\Users\Richard\source\repos\Projeto-Loja-Games\Images\tr\" + Program.jgtr[x] + ".jpg";
                        }

                    }

                sql = "SELECT nome_terror FROM cad_terror WHERE id = " + Program.jgesc + ";";
                cmnd = new MySqlCommand(sql, conexao);
                pegarnome = cmnd.ExecuteReader();
                pegarnome.Read();
                jogotr1n = pegarnome["nome_terror"].ToString();
                label1.Text = jogotr1n;
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
               
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lst = new ListaJogos();
            lst.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Program.buy == 0)
            {
                MessageBox.Show("Crie uma conta ou faça login para comprar!");
            }
            else
            {
                this.Hide();
                var compra = new FimCompra();
                compra.Show();
            }
        }
    }
    }
