using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria
{
    class conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=dbpizza;user=root;pwd=12345678");
        //estanciando o mysqlconnection com con = new
        public static string msg;

        public MySqlConnection ConnectarBD()
        {   //Tentativa de erro
            try
            {
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {   //Tentativa de erro
            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }
    }
}
