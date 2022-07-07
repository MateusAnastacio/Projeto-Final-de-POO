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
    public partial class CadVeiculo : Form
    {
        public CadVeiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            string mensagem = controle.CadastrarVeiculo(txbPlaca.Text, txbMarca.Text, txbModelo.Text, txbCor.Text, txbAno.Text);       

            MessageBox.Show(mensagem, "CadastroVeiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
