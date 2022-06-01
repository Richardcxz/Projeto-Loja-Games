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

            string sqlid1 = "SELECT ID FROM cad_acao where ID =(Select Max(ID) from cad_acao);";
            MySqlCommand cmnd1 = new MySqlCommand(sqlid1, conexao);
            pegarlastid = cmnd1.ExecuteReader();
            pegarlastid.Read();
            string strlastid1 = pegarlastid["ID"].ToString();
            sqlidi1 = Int32.Parse(strlastid1);
            Program.idnumberac = sqlidi1;
            pegarlastid.Close();

            string sqlid2 = "SELECT ID FROM cad_rpg where ID =(Select Max(ID) from cad_rpg);";
            MySqlCommand cmnd2 = new MySqlCommand(sqlid2, conexao);
            pegarlastid = cmnd2.ExecuteReader();
            pegarlastid.Read();
            string strlastid2 = pegarlastid["ID"].ToString();
            sqlidi2 = Int32.Parse(strlastid2);
            Program.idnumberrpg = sqlidi2;
            pegarlastid.Close();

            string sqlid3 = "SELECT ID FROM cad_aventura where ID =(Select Max(ID) from cad_aventura);";
            MySqlCommand cmnd3 = new MySqlCommand(sqlid3, conexao);
            pegarlastid = cmnd3.ExecuteReader();
            pegarlastid.Read();
            string strlastid3 = pegarlastid["ID"].ToString();
            sqlidi3 = Int32.Parse(strlastid3);
            Program.idnumberav = sqlidi3;
            pegarlastid.Close();

            string sqlid4 = "SELECT ID FROM cad_terror where ID =(Select Max(ID) from cad_terror);";
            MySqlCommand cmnd4 = new MySqlCommand(sqlid4, conexao);
            pegarlastid = cmnd4.ExecuteReader();
            pegarlastid.Read();
            string strlastid4 = pegarlastid["ID"].ToString();
            sqlidi4 = Int32.Parse(strlastid4);
            Program.idnumbertr = sqlidi4;
            pegarlastid.Close();

            string nomejogo = "teste";

            if (Projeto_Loja_Games.Program.lista == 1) {
                switch (nomejogo)
                {
                    default:
                        pictureBox1.ImageLocation = @"C:\imgproj\placeholder.png";
                        break;
                    case "Detroit":
                        pictureBox1.ImageLocation = @"C:\imgproj\detroit.png";
                        break;
                    case "detroit":
                        pictureBox1.ImageLocation = @"C:\imgproj\detroit.png";
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

                    if (Program.idnumberac >= 1)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac1 = pegarnome["nome_acao"].ToString();
                        label1.Text = jogoac1;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 2)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac2 = pegarnome["nome_acao"].ToString();
                        label2.Text = jogoac2;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 3)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac3 = pegarnome["nome_acao"].ToString();
                        label3.Text = jogoac3;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 4)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac4 = pegarnome["nome_acao"].ToString();
                        label4.Text = jogoac4;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 5)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac5 = pegarnome["nome_acao"].ToString();
                        label5.Text = jogoac5;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 6)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac6 = pegarnome["nome_acao"].ToString();
                        label6.Text = jogoac6;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 7)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac7 = pegarnome["nome_acao"].ToString();
                        label7.Text = jogoac7;
                        pegarnome.Close();
                    }

                    if (Program.idnumberac >= 8)
                    {
                        sql = "SELECT nome_acao FROM cad_acao WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoac8 = pegarnome["nome_acao"].ToString();
                        label8.Text = jogoac8;
                        pegarnome.Close();
                    }

                    conexao.Close();

                    break;
                case 2:
                    label9.Text = "JOGOS DE RPG";
                    conexao.Open();

                    if (Program.idnumberrpg >= 1)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor1 = pegarnome["nome_rpg"].ToString();
                        label1.Text = jogor1;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 2)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor2 = pegarnome["nome_rpg"].ToString();
                        label2.Text = jogor2;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 3)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor3 = pegarnome["nome_rpg"].ToString();
                        label3.Text = jogor3;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 4)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor4 = pegarnome["nome_rpg"].ToString();
                        label4.Text = jogor4;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 5)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor5 = pegarnome["nome_rpg"].ToString();
                        label5.Text = jogor5;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 6)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor6 = pegarnome["nome_rpg"].ToString();
                        label6.Text = jogor6;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 7)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor7 = pegarnome["nome_rpg"].ToString();
                        label7.Text = jogor7;
                        pegarnome.Close();
                    }

                    if (Program.idnumberrpg >= 8)
                    {
                        sql = "SELECT nome_rpg FROM cad_rpg WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogor8 = pegarnome["nome_rpg"].ToString();
                        label8.Text = jogor8;
                        pegarnome.Close();
                    }

                    conexao.Close();

                    break;
                case 3:
                    label9.Text = "JOGOS DE AVENTURA";
                    conexao.Open();

                    if (Program.idnumberav >= 1)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav1 = pegarnome["nome_aventura"].ToString();
                        label1.Text = jogoav1;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 2)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav2 = pegarnome["nome_aventura"].ToString();
                        label2.Text = jogoav2;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 3)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav3 = pegarnome["nome_aventura"].ToString();
                        label3.Text = jogoav3;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 4)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav4 = pegarnome["nome_aventura"].ToString();
                        label4.Text = jogoav4;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 5)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav5 = pegarnome["nome_aventura"].ToString();
                        label5.Text = jogoav5;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 6)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav6 = pegarnome["nome_aventura"].ToString();
                        label6.Text = jogoav6;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 7)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav7 = pegarnome["nome_aventura"].ToString();
                        label7.Text = jogoav7;
                        pegarnome.Close();
                    }

                    if (Program.idnumberav >= 8)
                    {
                        sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogoav8 = pegarnome["nome_aventura"].ToString();
                        label8.Text = jogoav8;
                        pegarnome.Close();
                    }


                    conexao.Close();


                    break;
                case 4:
                    label9.Text = "JOGOS DE TERROR";
                    conexao.Open();

                    if (Program.idnumbertr >= 1)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 1;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr1 = pegarnome["nome_terror"].ToString();
                        label1.Text = jogotr1;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 2)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 2;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr2 = pegarnome["nome_terror"].ToString();
                        label2.Text = jogotr2;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 3)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 3;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr3 = pegarnome["nome_terror"].ToString();
                        label3.Text = jogotr3;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 4)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 4;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr4 = pegarnome["nome_terror"].ToString();
                        label4.Text = jogotr4;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 5)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 5;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr5 = pegarnome["nome_terror"].ToString();
                        label5.Text = jogotr5;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 6)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 6;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr6 = pegarnome["nome_terror"].ToString();
                        label6.Text = jogotr6;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 7)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 7;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr7 = pegarnome["nome_terror"].ToString();
                        label7.Text = jogotr7;
                        pegarnome.Close();
                    }

                    if (Program.idnumbertr >= 8)
                    {
                        sql = "SELECT nome_terror FROM cad_terror WHERE id = 8;";
                        cmnd = new MySqlCommand(sql, conexao);
                        pegarnome = cmnd.ExecuteReader();
                        pegarnome.Read();
                        string jogotr8 = pegarnome["nome_terror"].ToString();
                        label8.Text = jogotr8;
                        pegarnome.Close();
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
    }
}
