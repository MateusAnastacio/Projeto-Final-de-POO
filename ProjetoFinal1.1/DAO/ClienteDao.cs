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
        Cliente obj = new Cliente();
        public String cadastrarCliente(Cliente obj)
        {     

                
                cmd.CommandText = "insert into cliente (idCliente, nome, sexo, rg, cpf, tipoPessoa, cep, uf, enderco, numero, complemento, telefone, emai) values ( @idCliente, @nome,  @sexo, @rg, @cpf, @tipoPessoa, @cep, @uf, @endereco, @numero, @complemento, @telefone, @emai);";
                cmd.Parameters.AddWithValue("@idCliente", obj.idCliente);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@sexo", obj.sexo);
                cmd.Parameters.AddWithValue("@rg", obj.rg);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@tipoPessoa", obj.tipoPessoa);
                cmd.Parameters.AddWithValue("@cep", obj.cep);
                cmd.Parameters.AddWithValue("@uf", obj.uf);
                cmd.Parameters.AddWithValue("@endereco", obj.endereco);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@complemento", obj.complento);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@emai", obj.email);          
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

