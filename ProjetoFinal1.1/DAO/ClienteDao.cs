using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using ProjetoFinal1._1.Apresentação;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using ProjetoFinal1._1.Modelo;

namespace ProjetoFinal1._1.DAO
{
    internal class ClienteDao
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();      
        
        public String cadastrarCliente(String id, String nome, String sexo, String rg, String cpf, String tipoPessoa, String cep, String uf, String endereco, String numero, String complento, String telefone, String email)
        {     

                
                cmd.CommandText = "insert into cliente (idCliente, nome, sexo, rg, cpf, tipoPessoa, cep, uf, enderco, numero, complemento, telefone, emai) values ( @idCliente, @nome,  @sexo, @rg, @cpf, @tipoPessoa, @cep, @uf, @endereco, @numero, @complemento, @telefone, @emai);";
                cmd.Parameters.AddWithValue("@idCliente", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@tipoPessoa", tipoPessoa);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@complemento", complento);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@emai", email);          
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

