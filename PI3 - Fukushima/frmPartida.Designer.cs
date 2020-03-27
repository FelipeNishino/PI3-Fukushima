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
            this.lstAzulejosFabricas = new System.Windows.Forms.ListBox();
            this.btnListarFabricas = new System.Windows.Forms.Button();
            this.txtStatusPartida = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoDebugN = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoDebugS = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboFabricas = new System.Windows.Forms.ComboBox();
            this.lstAzulejosCentro = new System.Windows.Forms.ListBox();
            this.btnListarCentro = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fabricas";
            // 
            // lstAzulejosFabricas
            // 
            this.lstAzulejosFabricas.FormattingEnabled = true;
            this.lstAzulejosFabricas.Location = new System.Drawing.Point(6, 19);
            this.lstAzulejosFabricas.Name = "lstAzulejosFabricas";
            this.lstAzulejosFabricas.Size = new System.Drawing.Size(186, 160);
            this.lstAzulejosFabricas.TabIndex = 3;
            // 
            // btnListarFabricas
            // 
            this.btnListarFabricas.Location = new System.Drawing.Point(5, 185);
            this.btnListarFabricas.Name = "btnListarFabricas";
            this.btnListarFabricas.Size = new System.Drawing.Size(187, 23);
            this.btnListarFabricas.TabIndex = 2;
            this.btnListarFabricas.Text = "Listar";
            this.btnListarFabricas.UseVisualStyleBackColor = true;
            this.btnListarFabricas.Click += new System.EventHandler(this.btnListarFabricas_Click);
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
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(16, 424);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 4;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(52, 19);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJogador.TabIndex = 6;
            this.txtIdJogador.Text = "27";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(52, 45);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJogador.TabIndex = 7;
            this.txtSenhaJogador.Text = "3CEC0B";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtIdJogador);
            this.groupBox3.Controls.Add(this.txtSenhaJogador);
            this.groupBox3.Location = new System.Drawing.Point(24, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 83);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // rdoDebugN
            // 
            this.rdoDebugN.AutoSize = true;
            this.rdoDebugN.Checked = true;
            this.rdoDebugN.Location = new System.Drawing.Point(25, 42);
            this.rdoDebugN.Name = "rdoDebugN";
            this.rdoDebugN.Size = new System.Drawing.Size(45, 17);
            this.rdoDebugN.TabIndex = 10;
            this.rdoDebugN.TabStop = true;
            this.rdoDebugN.Text = "Não";
            this.rdoDebugN.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoDebugS);
            this.groupBox4.Controls.Add(this.rdoDebugN);
            this.groupBox4.Location = new System.Drawing.Point(85, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 69);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usar txt p/ jogar?";
            // 
            // rdoDebugS
            // 
            this.rdoDebugS.AutoSize = true;
            this.rdoDebugS.Location = new System.Drawing.Point(25, 19);
            this.rdoDebugS.Name = "rdoDebugS";
            this.rdoDebugS.Size = new System.Drawing.Size(42, 17);
            this.rdoDebugS.TabIndex = 11;
            this.rdoDebugS.Text = "Sim";
            this.rdoDebugS.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.cboFabricas);
            this.groupBox5.Location = new System.Drawing.Point(566, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 226);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // cboFabricas
            // 
            this.cboFabricas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFabricas.Enabled = false;
            this.cboFabricas.FormattingEnabled = true;
            this.cboFabricas.Items.AddRange(new object[] {
            "centro",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboFabricas.Location = new System.Drawing.Point(21, 185);
            this.cboFabricas.Name = "cboFabricas";
            this.cboFabricas.Size = new System.Drawing.Size(187, 21);
            this.cboFabricas.TabIndex = 0;
            // 
            // lstAzulejosCentro
            // 
            this.lstAzulejosCentro.FormattingEnabled = true;
            this.lstAzulejosCentro.Location = new System.Drawing.Point(7, 19);
            this.lstAzulejosCentro.Name = "lstAzulejosCentro";
            this.lstAzulejosCentro.Size = new System.Drawing.Size(187, 160);
            this.lstAzulejosCentro.TabIndex = 13;
            // 
            // btnListarCentro
            // 
            this.btnListarCentro.Location = new System.Drawing.Point(7, 185);
            this.btnListarCentro.Name = "btnListarCentro";
            this.btnListarCentro.Size = new System.Drawing.Size(187, 23);
            this.btnListarCentro.TabIndex = 14;
            this.btnListarCentro.Text = "Listar";
            this.btnListarCentro.UseVisualStyleBackColor = true;
            this.btnListarCentro.Click += new System.EventHandler(this.btnListarCentro_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstAzulejosCentro);
            this.groupBox6.Controls.Add(this.btnListarCentro);
            this.groupBox6.Location = new System.Drawing.Point(234, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 221);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Centro";
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtStatusPartida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPartida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStatusPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnListarJogadoresPartida;
        private System.Windows.Forms.Button btnListarFabricas;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.ListBox lstAzulejosFabricas;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoDebugN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoDebugS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboFabricas;
        private System.Windows.Forms.ListBox lstAzulejosCentro;
        private System.Windows.Forms.Button btnListarCentro;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}