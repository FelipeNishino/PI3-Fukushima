namespace PI3___Fukushima
{
    partial class frmPartida
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.btnListarJogadoresPartida = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarFabricas = new System.Windows.Forms.Button();
            this.cboFabricas = new System.Windows.Forms.ComboBox();
            this.txtStatusPartida = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lstAzulejosFabricas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaJogadores);
            this.groupBox1.Controls.Add(this.btnListarJogadoresPartida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores";
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.Location = new System.Drawing.Point(7, 23);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(186, 121);
            this.lstListaJogadores.TabIndex = 4;
            // 
            // btnListarJogadoresPartida
            // 
            this.btnListarJogadoresPartida.Location = new System.Drawing.Point(6, 150);
            this.btnListarJogadoresPartida.Name = "btnListarJogadoresPartida";
            this.btnListarJogadoresPartida.Size = new System.Drawing.Size(188, 23);
            this.btnListarJogadoresPartida.TabIndex = 1;
            this.btnListarJogadoresPartida.Text = "Listar";
            this.btnListarJogadoresPartida.UseVisualStyleBackColor = true;
            this.btnListarJogadoresPartida.Click += new System.EventHandler(this.btnListarJogadoresPartida_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAzulejosFabricas);
            this.groupBox2.Controls.Add(this.btnListarFabricas);
            this.groupBox2.Controls.Add(this.cboFabricas);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fabricas";
            // 
            // btnListarFabricas
            // 
            this.btnListarFabricas.Location = new System.Drawing.Point(6, 222);
            this.btnListarFabricas.Name = "btnListarFabricas";
            this.btnListarFabricas.Size = new System.Drawing.Size(187, 23);
            this.btnListarFabricas.TabIndex = 2;
            this.btnListarFabricas.Text = "Listar";
            this.btnListarFabricas.UseVisualStyleBackColor = true;
            this.btnListarFabricas.Click += new System.EventHandler(this.btnListarFabricas_Click);
            // 
            // cboFabricas
            // 
            this.cboFabricas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFabricas.FormattingEnabled = true;
            this.cboFabricas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "centro"});
            this.cboFabricas.Location = new System.Drawing.Point(7, 20);
            this.cboFabricas.Name = "cboFabricas";
            this.cboFabricas.Size = new System.Drawing.Size(187, 21);
            this.cboFabricas.TabIndex = 0;
            // 
            // txtStatusPartida
            // 
            this.txtStatusPartida.Enabled = false;
            this.txtStatusPartida.Location = new System.Drawing.Point(587, 417);
            this.txtStatusPartida.Name = "txtStatusPartida";
            this.txtStatusPartida.Size = new System.Drawing.Size(100, 20);
            this.txtStatusPartida.TabIndex = 2;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(713, 415);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarPartida.TabIndex = 3;
            this.btnIniciarPartida.Text = "Iniciar";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            // 
            // lstAzulejosFabricas
            // 
            this.lstAzulejosFabricas.FormattingEnabled = true;
            this.lstAzulejosFabricas.Location = new System.Drawing.Point(7, 51);
            this.lstAzulejosFabricas.Name = "lstAzulejosFabricas";
            this.lstAzulejosFabricas.Size = new System.Drawing.Size(186, 160);
            this.lstAzulejosFabricas.TabIndex = 3;
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtStatusPartida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFabricas;
        private System.Windows.Forms.TextBox txtStatusPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnListarJogadoresPartida;
        private System.Windows.Forms.Button btnListarFabricas;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.ListBox lstAzulejosFabricas;
    }
}