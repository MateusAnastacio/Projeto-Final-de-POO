using ProjetoFinal1._1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal1._1.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";      
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarlogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String login, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(login, senha, confSenha);
            return mensagem;
        }
        public String cadastrarCliente(String id, String nome, String sexo, String rg, String cpf, String tipoPessoa, String cep, String uf, String endereco, String numero, String complento, String telefone, String email)
        {
            
            ClienteDao cliente = new ClienteDao();
            this.mensagem = cliente.cadastrarCliente(id,
                                                     nome,
                                                     sexo,
                                                     rg,
                                                     cpf,
                                                     tipoPessoa,
                                                     cep,
                                                     uf,
                                                     endereco,
                                                     numero,
                                                     complento,
                                                     telefone,
                                                     email);       
            return mensagem; 
        }
        public String CadastrarVeiculo(String placa, String marca, String modelo, String cor, String ano)
        {
            
            VeiculoDao veiculodao = new VeiculoDao();
            this.mensagem = veiculodao.cadastrarVeiculo(placa, marca, modelo, cor, ano);
            return mensagem;
        }
    }
}
