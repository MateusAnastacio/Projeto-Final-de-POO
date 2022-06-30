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
    public partial class ConsultarVeiculo : Form
    {
        public ConsultarVeiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, IEnumerable<Veiculo> veiculoList)
        {
            listView1.Items.Clear();
            foreach (Veiculo aux in veiculoList)
            {
                ListViewItem item = new ListViewItem(aux.placa);
                item.SubItems.Add(aux.marca);
                item.SubItems.Add(aux.modelo);
                item.SubItems.Add(aux.cor);
                item.SubItems.Add(aux.ano);
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
