using System;
using System.Collections.Generic;
using ProjetoFinal1._1.Apresentação;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1._1.DAO
{
    class LoginDaoComandos
    {

        
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarlogin(String login, String senha)
        {
            cmd.CommandText = "select * from logins where login = @login and senha = @senha;";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
           
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }
        public String cadastrar(String login, String senha, String confSenha)
        {   

            
            if(senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values(@log, @sen);";
                cmd.Parameters.AddWithValue("@log", login);
                cmd.Parameters.AddWithValue("@sen", senha);

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
            }
            else
            {
                this.mensagem = "senhas não correspodem";
            }
            
            return mensagem;
            

        }           
    }
}
