using ProjetoFinal1._1.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1._1.DAO
{
    public class VeiculoDao
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        
        public String cadastrarVeiculo(String placa, String marca, String modelo, String cor, String ano)
        {

            
            cmd.CommandText = "insert into veiculo (placa, marca, modelo, cor, ano) values (@placa, @marca, @modelo, @cor, @ano);";
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@cor", cor);
            cmd.Parameters.AddWithValue("@ano", ano);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM O BANCO DE DADOS";

            }
            return mensagem;
        }
    }
}
    

