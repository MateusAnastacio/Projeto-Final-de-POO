using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1._1.DAO
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-EGACPQJT\MSSQLSERVER01;Initial Catalog=ProjetoFinal;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        public void desconectar()
        {

        }
            
    }
}
