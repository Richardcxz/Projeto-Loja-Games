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
    public partial class ListaJogos : Form
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
        
        public ListaJogos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;



            conexao = new MySqlConnection(data_source); 
            conexao.Open();

            if(Program.lista == 1) { 
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
                switch (Program.idnumberac)
                {
                    case 1:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = false;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 2:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 3:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 4:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 5:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 6:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 7:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = true;
                        pictureBox8.Enabled = false;
                        break;
                }
            }

            if (Program.lista == 2)
            {
                switch (Program.idnumberrpg)
                {
                    case 1:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = false;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 2:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 3:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 4:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 5:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 6:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 7:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = true;
                        pictureBox8.Enabled = false;
                        break;
                }
            }

            if (Program.lista == 3)
            {
                switch (Program.idnumberav)
                {
                    case 1:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = false;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 2:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 3:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 4:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 5:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 6:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 7:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = true;
                        pictureBox8.Enabled = false;
                        break;
                }
            }

            if (Program.lista == 4)
            {
                switch (Program.idnumbertr)
                {
                    case 1:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = false;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 2:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 3:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 4:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = false;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 5:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = false;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 6:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        break;
                    case 7:
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                        pictureBox5.Enabled = true;
                        pictureBox6.Enabled = true;
                        pictureBox7.Enabled = true;
                        pictureBox8.Enabled = false;
                        break;
                }
            }

            conexao.Close();

            switch (Projeto_Loja_Games.Program.lista)
            {
                //colocar ifs dependendo do nome do jogo, para puxar da pasta as imagens correspondentes
                //e caso não tenha o jogo na base de imagens, deixar uma foto padrão para os que não têm
                case 1:
                    label9.Text = "JOGOS DE AÇÃO";
                    conexao.Open();

                    String[] jogoac = new string[9];

                    if (Program.idnumberac >= 1)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[1] = pegarnome["nome_acao"].ToString();
                        label1.Text = jogoac[1];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 2)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[2] = pegarnome["nome_acao"].ToString();
                        label2.Text = jogoac[2];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 3)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[3] = pegarnome["nome_acao"].ToString();
                        label3.Text = jogoac[3];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 4)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[4] = pegarnome["nome_acao"].ToString();
                        label4.Text = jogoac[4];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 5)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[5] = pegarnome["nome_acao"].ToString();
                        label5.Text = jogoac[5];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 6)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[6] = pegarnome["nome_acao"].ToString();
                        label6.Text = jogoac[6];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 7)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[7] = pegarnome["nome_acao"].ToString();
                        label7.Text = jogoac[7];
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 8)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoac[8] = pegarnome["nome_acao"].ToString();
                        label8.Text = jogoac[8];
                        pegarnome.Close();
                    }

                    for (int x = 1; x <= sqlidi1; x++)
                    {
                        switch (jogoac[x])
                        {
                            default:
                                if (x == 1)
                                {
                                    pictureBox1.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 2)
                                {
                                    pictureBox2.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 3)
                                {
                                    pictureBox3.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 4)
                                {
                                    pictureBox4.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 5)
                                {
                                    pictureBox5.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 6)
                                {
                                    pictureBox6.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 7)
                                {
                                    pictureBox7.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 8)
                                {
                                    pictureBox8.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                break;

                            case "9":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "99":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "999":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;

                        }
                    }

                    conexao.Close();

                    break;
                case 2:
                    label9.Text = "JOGOS DE RPG";
                    conexao.Open();

                    String[] jogorpg = new string[9];

                    if (Program.idnumberrpg >= 1)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[1] = pegarnome["nome_rpg"].ToString();
                        label1.Text = jogorpg[1];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 2)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[2] = pegarnome["nome_rpg"].ToString();
                        label2.Text = jogorpg[2];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 3)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[3] = pegarnome["nome_rpg"].ToString();
                        label3.Text = jogorpg[3];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 4)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[4] = pegarnome["nome_rpg"].ToString();
                        label4.Text = jogorpg[4];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 5)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[5] = pegarnome["nome_rpg"].ToString();
                        label5.Text = jogorpg[5];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 6)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[6] = pegarnome["nome_rpg"].ToString();
                        label6.Text = jogorpg[6];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 7)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[7] = pegarnome["nome_rpg"].ToString();
                        label7.Text = jogorpg[7];
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 8)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogorpg[8] = pegarnome["nome_rpg"].ToString();
                        label8.Text = jogorpg[8];
                        pegarnome.Close();
                    }

                    for (int x = 1; x <= sqlidi2; x++)
                    {
                        switch (jogorpg[x])
                        {
                            default:
                                if (x == 1)
                                {
                                    pictureBox1.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 2)
                                {
                                    pictureBox2.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 3)
                                {
                                    pictureBox3.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 4)
                                {
                                    pictureBox4.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 5)
                                {
                                    pictureBox5.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 6)
                                {
                                    pictureBox6.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 7)
                                {
                                    pictureBox7.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 8)
                                {
                                    pictureBox8.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                break;

                            case "9":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "99":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "999":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;

                        }
                    }

                    conexao.Close();

                    break;
                case 3:
                    label9.Text = "JOGOS DE AVENTURA";
                    conexao.Open();

                    String[] jogoav = new string[9];

                    if (Program.idnumberav >= 1)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[1] = pegarnome["nome_aventura"].ToString();
                        label1.Text = jogoav[1];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 2)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[2] = pegarnome["nome_aventura"].ToString();
                        label2.Text = jogoav[2];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 3)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[3] = pegarnome["nome_aventura"].ToString();
                        label3.Text = jogoav[3];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 4)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[4] = pegarnome["nome_aventura"].ToString();
                        label4.Text = jogoav[4];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 5)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[5] = pegarnome["nome_aventura"].ToString();
                        label5.Text = jogoav[5];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 6)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[6] = pegarnome["nome_aventura"].ToString();
                        label6.Text = jogoav[6];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 7)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[7] = pegarnome["nome_aventura"].ToString();
                        label7.Text = jogoav[7];
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 8)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogoav[8] = pegarnome["nome_aventura"].ToString();
                        label8.Text = jogoav[8];
                        pegarnome.Close();
                    }

                    for (int x = 1; x <= sqlidi3; x++)
                    {
                        switch (jogoav[x])
                        {
                            default:
                                if (x == 1)
                                {
                                    pictureBox1.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 2)
                                {
                                    pictureBox2.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 3)
                                {
                                    pictureBox3.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 4)
                                {
                                    pictureBox4.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 5)
                                {
                                    pictureBox5.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 6)
                                {
                                    pictureBox6.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 7)
                                {
                                    pictureBox7.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 8)
                                {
                                    pictureBox8.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                break;

                            case "9":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "99":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "999":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;

                        }
                    }

                    conexao.Close();


                    break;
                case 4:
                    label9.Text = "JOGOS DE TERROR";
                    conexao.Open();

                    String[] jogotr = new string[9];

                    if (Program.idnumbertr >= 1)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[1] = pegarnome["nome_terror"].ToString();
                        label1.Text = jogotr[1];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 2)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[2] = pegarnome["nome_terror"].ToString();
                        label2.Text = jogotr[2];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 3)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[3] = pegarnome["nome_terror"].ToString();
                        label3.Text = jogotr[3];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 4)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[4] = pegarnome["nome_terror"].ToString();
                        label4.Text = jogotr[4];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 5)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[5] = pegarnome["nome_terror"].ToString();
                        label5.Text = jogotr[5];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 6)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[6] = pegarnome["nome_terror"].ToString();
                        label6.Text = jogotr[6];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 7)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[7] = pegarnome["nome_terror"].ToString();
                        label7.Text = jogotr[7];
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 8)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        jogotr[8] = pegarnome["nome_terror"].ToString();
                        label8.Text = jogotr[8];
                        pegarnome.Close();
                    }

                    for (int x = 1; x <= sqlidi4; x++)
                    {
                        switch (jogotr[x])
                        {
                            default:
                                if (x == 1)
                                {
                                    pictureBox1.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 2)
                                {
                                    pictureBox2.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 3)
                                {
                                    pictureBox3.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 4)
                                {
                                    pictureBox4.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 5)
                                {
                                    pictureBox5.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 6)
                                {
                                    pictureBox6.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 7)
                                {
                                    pictureBox7.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                else if (x == 8)
                                {
                                    pictureBox8.ImageLocation = @"C:\imgproj\placeholder.jpg";
                                }
                                break;

                            case "9":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "99":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;
                            case "999":
                                pictureBox1.ImageLocation = @"C:\imgproj\";
                                break;

                        }
                    }

                    conexao.Close();

                    break;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (Projeto_Loja_Games.Program.isadm == 1)
            {
                this.Hide();
                var mnadm = new Form1adm();
                mnadm.Show();
            }
            else if (Projeto_Loja_Games.Program.islogged == 1) {
                this.Hide();
                var init = new Form1log();
                init.Show();
            }
            else
            {
                this.Hide();
                var mnunl = new Form1();
                mnunl.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 1;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 2;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 3;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 4;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 5;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 6;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 7;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Projeto_Loja_Games.Program.jgesc = 8;
            this.Hide();
            var jg = new Jogo();
            jg.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
