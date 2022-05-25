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
        public dbadm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if(Projeto_Loja_Games.Program.dboption == 1)
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

                string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
                
                conexao10 = new MySqlConnection(data_source);

                string sql = "INSERT INTO cad_acao (nome, desc) " + 
                    "VALUES ('" +textBox1.Text + "','" + textBox2.Text + "') ";

                comando = new MySqlCommand(sql, conexao10);

                conexao10.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Jogo inserido com sucesso!");

                conexao10.Close();
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
