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
    public partial class Menu : Form
    {
        //Form1 form1 = new Form1();
        //form1.Close();
        

        private Form formAtivo;
        public Menu()
        {
            InitializeComponent();
        }
        private void FormShow(Form form)
        {
            ActiveFormClose();
            formAtivo = form;
            form.TopLevel = false;
            panelForm.Controls.Add(form);
            form.BringToFront();
            form.Show();

        }

        private void ActiveFormClose()
        {
            if (formAtivo != null)
                formAtivo.Close();
        }
        private void ActiveButton(Button formAtivo)
        {
            foreach (Control control in panelForm.Controls)
                control.ForeColor = Color.Black;

            formAtivo.ForeColor = Color.Red;
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new Estoque());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
