using ProjetoFinal1._1.DAO;
using ProjetoFinal1._1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal1._1.Apresentação
{
    public partial class CadCliente : Form
    {
        
        public CadCliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrarCliente(txbId.Text, txbNome.Text, cbSexo.Text, txbRg.Text, txbCpf.Text, cbTipoPessoa.Text, txbCep.Text, cbUf.Text, txbEndereço.Text, txbNumero.Text, txbComplemento.Text, txbTelefone.Text, txbEmai.Text);

            MessageBox.Show(mensagem, "cadastroCliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
//private void button1_Click(object sender, EventArgs e)
//{
//    Controle controle = new Controle();
//    string mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfSenha.Text);
//    if (controle.tem)
//    {
//        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    else
//    {
//        MessageBox.Show(controle.mensagem);

//    }

//}