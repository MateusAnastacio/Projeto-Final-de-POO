namespace ProjetoFinal1._1.Apresentação
{
    partial class CadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.llbSexoCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbEndereço = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbEmai = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(12, 9);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(40, 15);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "Nome";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(401, 9);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(18, 15);
            this.lbIdCliente.TabIndex = 1;
            this.lbIdCliente.Text = "ID";
            // 
            // llbSexoCliente
            // 
            this.llbSexoCliente.AutoSize = true;
            this.llbSexoCliente.Location = new System.Drawing.Point(12, 49);
            this.llbSexoCliente.Name = "llbSexoCliente";
            this.llbSexoCliente.Size = new System.Drawing.Size(32, 15);
            this.llbSexoCliente.TabIndex = 2;
            this.llbSexoCliente.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "tipo de Pessoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "CEP";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Maculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(62, 49);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 23);
            this.cbSexo.TabIndex = 10;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(62, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(333, 23);
            this.txbNome.TabIndex = 11;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(425, 6);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(144, 23);
            this.txbId.TabIndex = 12;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(411, 52);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(158, 23);
            this.txbCpf.TabIndex = 13;
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(217, 49);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(132, 23);
            this.txbRg.TabIndex = 14;
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(102, 105);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(121, 23);
            this.cbTipoPessoa.TabIndex = 15;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(290, 105);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(175, 23);
            this.txbCep.TabIndex = 16;
            // 
            // txbEndereço
            // 
            this.txbEndereço.Location = new System.Drawing.Point(66, 145);
            this.txbEndereço.Name = "txbEndereço";
            this.txbEndereço.Size = new System.Drawing.Size(329, 23);
            this.txbEndereço.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "UF";
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "",
            "AL",
            "",
            "AP",
            "",
            "AM",
            "",
            "BA",
            "",
            "CE",
            "",
            "DF",
            "",
            "ES",
            "",
            "GO",
            "MA",
            "",
            "MT",
            "",
            "MG",
            "",
            "PA",
            "",
            "PB",
            "",
            "PR",
            "",
            "PE",
            "",
            "PI",
            "",
            "RJ",
            "",
            "RN",
            "RS",
            "",
            "RO",
            "",
            "RR",
            "",
            "SC",
            "",
            "SP",
            "",
            "SE",
            "",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(498, 105);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(72, 23);
            this.cbUf.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(458, 145);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(98, 23);
            this.txbNumero.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Complemento";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(102, 189);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(60, 23);
            this.txbComplemento.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Telefone";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(225, 189);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(139, 23);
            this.txbTelefone.TabIndex = 25;
            this.txbTelefone.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "E-mail";
            // 
            // txbEmai
            // 
            this.txbEmai.Location = new System.Drawing.Point(414, 189);
            this.txbEmai.Name = "txbEmai";
            this.txbEmai.Size = new System.Drawing.Size(144, 23);
            this.txbEmai.TabIndex = 27;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(196, 262);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(153, 23);
            this.btnCadastrar.TabIndex = 30;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbEmai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEndereço);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.cbTipoPessoa);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llbSexoCliente);
            this.Controls.Add(this.lbIdCliente);
            this.Controls.Add(this.lbNomeCliente);
            this.Name = "CadCliente";
            this.Text = "CadCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNomeCliente;
        private Label lbIdCliente;
        private Label llbSexoCliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private ComboBox cbSexo;
        private TextBox txbNome;
        private TextBox txbId;
        private TextBox txbCpf;
        private TextBox txbRg;
        private ComboBox cbTipoPessoa;
        private TextBox txbCep;
        private TextBox txbEndereço;
        private Label label1;
        private ComboBox cbUf;
        private Label label2;
        private TextBox txbNumero;
        private Label label3;
        private TextBox txbComplemento;
        private Label label11;
        private TextBox txbTelefone;
        private Label label12;
        private TextBox txbEmai;
        private Button btnCadastrar;
        private Button button1;
    }
}