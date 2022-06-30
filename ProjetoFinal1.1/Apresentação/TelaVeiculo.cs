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
    public partial class TelaVeiculo : Form
    {
        public TelaVeiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadVeiculo cad = new CadVeiculo();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consulta = new ConsultarVeiculo(); 
            consulta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
