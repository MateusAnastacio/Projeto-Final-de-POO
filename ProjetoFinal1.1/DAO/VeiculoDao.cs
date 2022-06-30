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
        Cliente obj = new Cliente();
        public String cadastrarVeiculo(Veiculo veiculo)
        {


            cmd.CommandText = "INSERT INTO veiculo (placa, marca, modelo, cor, ano) VALUES(@placa, @marca, @modleo, @cor, @ano); ";
            cmd.Parameters.AddWithValue("@placa", veiculo.placa);
            cmd.Parameters.AddWithValue("@marca", veiculo.marca);
            cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
            cmd.Parameters.AddWithValue("@cor", veiculo.cor);
            cmd.Parameters.AddWithValue("@ano", veiculo.ano);

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
    

