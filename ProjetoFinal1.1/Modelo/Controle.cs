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
        public Cliente cadastrarCliente()
        {
            Cliente obj = new Cliente();
            ClienteDao cliente = new ClienteDao();
            obj = cliente.cadastrarCliente(obj.idCliente, obj.nome, obj.sexo, obj.rg, obj.cpf, obj.tipoPessoa, obj.cep, obj.uf, obj.endereco, obj.numero, obj.complento, obj.telefone, obj.email);       
            return obj; 
        }
        public String CadastrarVeiculo(Veiculo veiculo)
        {
            
            VeiculoDao veiculodao = new VeiculoDao();
            this.mensagem = veiculodao.cadastrarVeiculo(veiculo.placa, veiculo.marca, veiculo.modelo, veiculo.cor, veiculo.ano);
            return mensagem;
        }
    }
}
