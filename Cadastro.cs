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
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        public Cadastro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";

                conexao = new MySqlConnection(data_source);

                int idcad = 2;

                string sql = "INSERT INTO cad_cliente (nome,senha) " +
                    "VALUES ('" +textBox1.Text + "','" + textBox2.Text + "') "; 

                MySqlCommand cmnd = new MySqlCommand(sql, conexao);

                conexao.Open();
                cmnd.ExecuteReader();

                MessageBox.Show("Usuário Cadastrado.");

                this.Hide();
                var menucad = new Form1log();
                menucad.Show();

                conexao.Close();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var init = new Form1();
            init.Show();
        }
    }
}
