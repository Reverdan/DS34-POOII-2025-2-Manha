using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CrudPessoasManha.DAL
{
    public class Conexao
    {
        public static SqlConnection con = new SqlConnection();
        public static string mensagem = "";
        public static string stringConexao =
            @"Data Source = LAB833\SQLEXPRESS; Initial Catalog = aulaManha; 
            User ID = sa; Password = prof456; Encrypt = False";

        public static SqlConnection Conectar()
        {
            mensagem = "";
            con.ConnectionString = stringConexao;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)  
            { 
                mensagem += ex.Message;
            }
            return con;
        }

        public static void Desconectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                mensagem += ex.Message;
            }
        }
    }
}
