using ProjetoFinal1._1.DAO;
using ProjetoFinal1._1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //foreach (var aux in )
            //{
            //    ListViewItem item = new ListViewItem(aux.placa);
            //    item.SubItems.Add(aux.marca);
            //    item.SubItems.Add(aux.modelo);
            //    item.SubItems.Add(aux.cor);
            //    item.SubItems.Add(aux.ano);
            //    listView1.Items.Add(item);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();


            String veiculoPlaca;
            String veiculoMarca;
            String veiculoModelo;
            String veiculoCor;
            String veiculoAno;

            String pes = txbPesquisarPlaca.Text;

            

            veiculoPlaca = cmd.CommandText = "select placa FROM veiculo WHERE placa =  '+pes+' ";
            veiculoMarca = cmd.CommandText = "select marca FROM veiculo WHERE placa = '" +pes+ "' ";
            veiculoModelo = cmd.CommandText = "select modelo FROM veiculo WHERE placa = '" +pes+ "' ";
            veiculoCor = cmd.CommandText = "select cor FROM veiculo WHERE placa = '" +pes+ "' ";
            veiculoAno = cmd.CommandText = "select ano FROM veiculo WHERE placa = '" +pes+ "' ";
            cmd.Connection = con.conectar();
            cmd.ExecuteNonQuery();

            //List<String> lista = new List<String>();
            //lista.Add(veiculoPlaca);
            //lista.Add(veiculoMarca);
            //lista.Add(veiculoModelo);
            //lista.Add(veiculoCor);
            //lista.Add(veiculoAno);
            txbPlaca.Text = veiculoPlaca;
            txbMarca.Text = veiculoMarca;
            txbModelo.Text = veiculoModelo;
            txbCor.Text = veiculoCor;
            txbAno.Text = veiculoAno;

            
            
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            
            //    ListViewItem item = new ListViewItem(aux.veiculoPlaca);
            //    item.SubItems.Add(aux.veiculoMarca);
            //    item.SubItems.Add(aux.modelo);
            //    item.SubItems.Add(aux.cor);
            //    item.SubItems.Add(aux.ano);
            //    listView1.Items.Add(item);
            //}

        }
    }
}
