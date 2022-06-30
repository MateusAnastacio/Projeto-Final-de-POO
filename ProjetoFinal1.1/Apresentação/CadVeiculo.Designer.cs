namespace ProjetoFinal1._1.Apresentação
{
    partial class CadVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbCor = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(66, 6);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(155, 23);
            this.txbPlaca.TabIndex = 5;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(66, 52);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(155, 23);
            this.txbMarca.TabIndex = 6;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(66, 110);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(155, 23);
            this.txbModelo.TabIndex = 7;
            // 
            // txbCor
            // 
            this.txbCor.Location = new System.Drawing.Point(66, 156);
            this.txbCor.Name = "txbCor";
            this.txbCor.Size = new System.Drawing.Size(155, 23);
            this.txbCor.TabIndex = 8;
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(66, 200);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(155, 23);
            this.txbAno.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.txbCor);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadVeiculo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbPlaca;
        private TextBox txbMarca;
        private TextBox txbModelo;
        private TextBox txbCor;
        private TextBox txbAno;
        private Button button1;
        private Button button2;
    }
}