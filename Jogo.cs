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
        public Jogo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            switch (Projeto_Loja_Games.Program.jgesc)
            {
                //colocar ifs das categorias
                case 1:
                    switch(Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 2:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 3:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 4:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\imgproj\4662581.jpg";
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 6:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 7:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;
                case 8:
                    switch (Projeto_Loja_Games.Program.lista)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }

                    break;

            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                var lst = new ListaJogos();
                lst.Show();
            }
        }
    }
