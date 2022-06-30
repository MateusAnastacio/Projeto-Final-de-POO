using ProjetoFinal1._1.Apresentação;
using ProjetoFinal1._1.Modelo;

namespace ProjetoFinal1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            controle.acessar (txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {

                    MessageBox.Show("Logado com sucesso", "entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu bv = new Menu();
                    bv.Show();
                    
                    //preciso conseguir fechar a tela anterior("Form1")
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            CadastreSe cad = new CadastreSe();           
            cad.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}