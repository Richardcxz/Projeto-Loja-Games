using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Loja_Games
{
    internal class pegarnome
    {
        MySqlConnection conexao;
        MySqlConnection conexao2;
        MySqlDataReader dr;
        
        public string sql;
        string data_source = "datasource=localhost;username=root;password=1337;database=db_loja";
    }
}
