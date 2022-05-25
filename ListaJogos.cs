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
        MySqlDataReader dr;
        public string sql;
        string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
        
        public ListaJogos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            conexao = new MySqlConnection(data_source);

            switch (Projeto_Loja_Games.Program.lista)
            {
                //colocar ifs dependendo do nome do jogo, para puxar da pasta as imagens correspondentes
                //e caso não tenha o jogo na base de imagens, deixar uma foto padrão para os que não têm
                case 1:
                    label9.Text = "JOGOS DE AÇÃO";
                    pictureBox1.ImageLocation = @"C:\imgproj\639492.jpg";
                    break;
                case 2:
                    label9.Text = "JOGOS DE RPG";

                    break;
                case 3:
                    label9.Text = "JOGOS DE AVENTURA";

                    sql = "SELECT nome_aventura FROM cad_aventura WHERE id = 1;";
                    MySqlCommand cmnd = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    MySqlDataReader pegarnome = cmnd.ExecuteReader();
                    pegarnome.Read();
                    string jogo1 = pegarnome["nome_aventura"].ToString();
                    label1.Text = jogo1;


                    conexao.Close();


                    break;
                case 4:
                    label9.Text = "JOGOS DE TERROR";

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
