﻿using System;
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
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarVenda menu = new ConsultarVenda();
            menu.Show();
        }
    }
}
