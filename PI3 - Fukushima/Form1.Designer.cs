namespace PI3___Fukushima
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPartidas = new System.Windows.Forms.ComboBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatusEntrarPartida = new System.Windows.Forms.Label();
            this.txtStatusEntrarPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrarPartida = new System.Windows.Forms.Label();
            this.lblNomeJogadorEntrar = new System.Windows.Forms.Label();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.txtNomeJogadorEntrar = new System.Windows.Forms.TextBox();
            this.lblIdEntrarPartida = new System.Windows.Forms.Label();
            this.txtIdEntrarPartida = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblVersaoDll = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.txtNomeCriarPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaCriarPartida = new System.Windows.Forms.Label();
            this.txtSenhaCriarPartida = new System.Windows.Forms.TextBox();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPartidas);
            this.groupBox1.Controls.Add(this.btnListarPartidas);
            this.groupBox1.Location = new System.Drawing.Point(46, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar";
            // 
            // cboPartidas
            // 
            this.cboPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartidas.FormattingEnabled = true;
            this.cboPartidas.Location = new System.Drawing.Point(88, 40);
            this.cboPartidas.Name = "cboPartidas";
            this.cboPartidas.Size = new System.Drawing.Size(316, 21);
            this.cboPartidas.TabIndex = 1;
            this.cboPartidas.SelectedIndexChanged += new System.EventHandler(this.cboPartidas_SelectedIndexChanged);
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(7, 40);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(75, 23);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatusEntrarPartida);
            this.groupBox2.Controls.Add(this.txtStatusEntrarPartida);
            this.groupBox2.Controls.Add(this.lblSenhaEntrarPartida);
            this.groupBox2.Controls.Add(this.lblNomeJogadorEntrar);
            this.groupBox2.Controls.Add(this.txtSenhaEntrarPartida);
            this.groupBox2.Controls.Add(this.lblIdEntrarPartida);
            this.groupBox2.Controls.Add(this.txtNomeJogadorEntrar);
            this.groupBox2.Controls.Add(this.txtIdEntrarPartida);
            this.groupBox2.Controls.Add(this.btnEntrarPartida);
            this.groupBox2.Location = new System.Drawing.Point(46, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrar";
            // 
            // lblStatusEntrarPartida
            // 
            this.lblStatusEntrarPartida.AutoSize = true;
            this.lblStatusEntrarPartida.Location = new System.Drawing.Point(7, 74);
            this.lblStatusEntrarPartida.Name = "lblStatusEntrarPartida";
            this.lblStatusEntrarPartida.Size = new System.Drawing.Size(37, 13);
            this.lblStatusEntrarPartida.TabIndex = 8;
            this.lblStatusEntrarPartida.Text = "Status";
            this.lblStatusEntrarPartida.Click += new System.EventHandler(this.lblStatusPartida_Click);
            // 
            // txtStatusEntrarPartida
            // 
            this.txtStatusEntrarPartida.Enabled = false;
            this.txtStatusEntrarPartida.Location = new System.Drawing.Point(88, 71);
            this.txtStatusEntrarPartida.Name = "txtStatusEntrarPartida";
            this.txtStatusEntrarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtStatusEntrarPartida.TabIndex = 7;
            // 
            // lblSenhaEntrarPartida
            // 
            this.lblSenhaEntrarPartida.AutoSize = true;
            this.lblSenhaEntrarPartida.Location = new System.Drawing.Point(6, 48);
            this.lblSenhaEntrarPartida.Name = "lblSenhaEntrarPartida";
            this.lblSenhaEntrarPartida.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEntrarPartida.TabIndex = 6;
            this.lblSenhaEntrarPartida.Text = "Senha";
            // 
            // lblNomeJogadorEntrar
            // 
            this.lblNomeJogadorEntrar.AutoSize = true;
            this.lblNomeJogadorEntrar.Location = new System.Drawing.Point(6, 119);
            this.lblNomeJogadorEntrar.Name = "lblNomeJogadorEntrar";
            this.lblNomeJogadorEntrar.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogadorEntrar.TabIndex = 5;
            this.lblNomeJogadorEntrar.Text = "Nome Jogador";
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(88, 45);
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaEntrarPartida.TabIndex = 4;
            // 
            // txtNomeJogadorEntrar
            // 
            this.txtNomeJogadorEntrar.Location = new System.Drawing.Point(88, 116);
            this.txtNomeJogadorEntrar.Name = "txtNomeJogadorEntrar";
            this.txtNomeJogadorEntrar.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJogadorEntrar.TabIndex = 3;
            // 
            // lblIdEntrarPartida
            // 
            this.lblIdEntrarPartida.AutoSize = true;
            this.lblIdEntrarPartida.Location = new System.Drawing.Point(6, 22);
            this.lblIdEntrarPartida.Name = "lblIdEntrarPartida";
            this.lblIdEntrarPartida.Size = new System.Drawing.Size(18, 13);
            this.lblIdEntrarPartida.TabIndex = 2;
            this.lblIdEntrarPartida.Text = "ID";
            // 
            // txtIdEntrarPartida
            // 
            this.txtIdEntrarPartida.Location = new System.Drawing.Point(88, 19);
            this.txtIdEntrarPartida.Name = "txtIdEntrarPartida";
            this.txtIdEntrarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtIdEntrarPartida.TabIndex = 1;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(113, 161);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarPartida.TabIndex = 0;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSenhaCriarPartida);
            this.groupBox3.Controls.Add(this.lblSenhaCriarPartida);
            this.groupBox3.Controls.Add(this.txtNomeCriarPartida);
            this.groupBox3.Controls.Add(this.lblNomePartida);
            this.groupBox3.Controls.Add(this.btnCriarPartida);
            this.groupBox3.Location = new System.Drawing.Point(256, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 190);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(119, 161);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 0;
            this.btnCriarPartida.Text = "Criar";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblVersaoDll
            // 
            this.lblVersaoDll.AutoSize = true;
            this.lblVersaoDll.Location = new System.Drawing.Point(666, 425);
            this.lblVersaoDll.Name = "lblVersaoDll";
            this.lblVersaoDll.Size = new System.Drawing.Size(0, 13);
            this.lblVersaoDll.TabIndex = 3;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(7, 20);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(71, 13);
            this.lblNomePartida.TabIndex = 1;
            this.lblNomePartida.Text = "Nome Partida";
            // 
            // txtNomeCriarPartida
            // 
            this.txtNomeCriarPartida.Location = new System.Drawing.Point(94, 17);
            this.txtNomeCriarPartida.Name = "txtNomeCriarPartida";
            this.txtNomeCriarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCriarPartida.TabIndex = 2;
            // 
            // lblSenhaCriarPartida
            // 
            this.lblSenhaCriarPartida.AutoSize = true;
            this.lblSenhaCriarPartida.Location = new System.Drawing.Point(7, 51);
            this.lblSenhaCriarPartida.Name = "lblSenhaCriarPartida";
            this.lblSenhaCriarPartida.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCriarPartida.TabIndex = 3;
            this.lblSenhaCriarPartida.Text = "Senha";
            // 
            // txtSenhaCriarPartida
            // 
            this.txtSenhaCriarPartida.Location = new System.Drawing.Point(94, 48);
            this.txtSenhaCriarPartida.Name = "txtSenhaCriarPartida";
            this.txtSenhaCriarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCriarPartida.TabIndex = 4;
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Location = new System.Drawing.Point(489, 193);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(0, 13);
            this.lblFeedBack.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.lblVersaoDll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblSenhaEntrarPartida;
        private System.Windows.Forms.Label lblNomeJogadorEntrar;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeJogadorEntrar;
        private System.Windows.Forms.Label lblIdEntrarPartida;
        private System.Windows.Forms.TextBox txtIdEntrarPartida;
        private System.Windows.Forms.TextBox txtStatusEntrarPartida;
        private System.Windows.Forms.Label lblStatusEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblVersaoDll;
        private System.Windows.Forms.Label lblSenhaCriarPartida;
        private System.Windows.Forms.TextBox txtNomeCriarPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtSenhaCriarPartida;
        private System.Windows.Forms.Label lblFeedBack;
    }
}

