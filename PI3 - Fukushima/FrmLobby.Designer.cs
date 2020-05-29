namespace PI3___Fukushima
{
    partial class FrmLobby
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
            this.lblSenhaEntrarPartida = new System.Windows.Forms.Label();
            this.lblNomeJogadorEntrar = new System.Windows.Forms.Label();
            this.txtEntrarSenha = new System.Windows.Forms.TextBox();
            this.lblIdEntrarPartida = new System.Windows.Forms.Label();
            this.txtEntrarNome = new System.Windows.Forms.TextBox();
            this.txtEntrarId = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCriarSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaCriarPartida = new System.Windows.Forms.Label();
            this.txtCriarNome = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblVersaoDll = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstSala = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboDebug = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPartidas);
            this.groupBox1.Controls.Add(this.btnListarPartidas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partidas";
            // 
            // cboPartidas
            // 
            this.cboPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartidas.FormattingEnabled = true;
            this.cboPartidas.Location = new System.Drawing.Point(88, 18);
            this.cboPartidas.Name = "cboPartidas";
            this.cboPartidas.Size = new System.Drawing.Size(316, 21);
            this.cboPartidas.TabIndex = 1;
            this.cboPartidas.SelectedIndexChanged += new System.EventHandler(this.cboPartidas_SelectedIndexChanged);
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(7, 18);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(75, 21);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSenhaEntrarPartida);
            this.groupBox2.Controls.Add(this.lblNomeJogadorEntrar);
            this.groupBox2.Controls.Add(this.txtEntrarSenha);
            this.groupBox2.Controls.Add(this.lblIdEntrarPartida);
            this.groupBox2.Controls.Add(this.txtEntrarNome);
            this.groupBox2.Controls.Add(this.txtEntrarId);
            this.groupBox2.Controls.Add(this.btnEntrarPartida);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrar na sala";
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
            this.lblNomeJogadorEntrar.Location = new System.Drawing.Point(6, 73);
            this.lblNomeJogadorEntrar.Name = "lblNomeJogadorEntrar";
            this.lblNomeJogadorEntrar.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogadorEntrar.TabIndex = 5;
            this.lblNomeJogadorEntrar.Text = "Nome Jogador";
            // 
            // txtEntrarSenha
            // 
            this.txtEntrarSenha.Location = new System.Drawing.Point(88, 45);
            this.txtEntrarSenha.Name = "txtEntrarSenha";
            this.txtEntrarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtEntrarSenha.TabIndex = 4;
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
            // txtEntrarNome
            // 
            this.txtEntrarNome.Location = new System.Drawing.Point(88, 70);
            this.txtEntrarNome.Name = "txtEntrarNome";
            this.txtEntrarNome.Size = new System.Drawing.Size(100, 20);
            this.txtEntrarNome.TabIndex = 3;
            // 
            // txtEntrarId
            // 
            this.txtEntrarId.Location = new System.Drawing.Point(88, 19);
            this.txtEntrarId.Name = "txtEntrarId";
            this.txtEntrarId.Size = new System.Drawing.Size(100, 20);
            this.txtEntrarId.TabIndex = 1;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(113, 96);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarPartida.TabIndex = 0;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCriarSenha);
            this.groupBox3.Controls.Add(this.lblSenhaCriarPartida);
            this.groupBox3.Controls.Add(this.txtCriarNome);
            this.groupBox3.Controls.Add(this.lblNomePartida);
            this.groupBox3.Controls.Add(this.btnCriarPartida);
            this.groupBox3.Location = new System.Drawing.Point(222, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar uma sala";
            // 
            // txtCriarSenha
            // 
            this.txtCriarSenha.Location = new System.Drawing.Point(88, 45);
            this.txtCriarSenha.Name = "txtCriarSenha";
            this.txtCriarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCriarSenha.TabIndex = 4;
            // 
            // lblSenhaCriarPartida
            // 
            this.lblSenhaCriarPartida.AutoSize = true;
            this.lblSenhaCriarPartida.Location = new System.Drawing.Point(6, 48);
            this.lblSenhaCriarPartida.Name = "lblSenhaCriarPartida";
            this.lblSenhaCriarPartida.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCriarPartida.TabIndex = 3;
            this.lblSenhaCriarPartida.Text = "Senha";
            // 
            // txtCriarNome
            // 
            this.txtCriarNome.Location = new System.Drawing.Point(88, 19);
            this.txtCriarNome.Name = "txtCriarNome";
            this.txtCriarNome.Size = new System.Drawing.Size(100, 20);
            this.txtCriarNome.TabIndex = 2;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(6, 22);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(71, 13);
            this.lblNomePartida.TabIndex = 1;
            this.lblNomePartida.Text = "Nome Partida";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(119, 96);
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
            this.lblVersaoDll.Location = new System.Drawing.Point(12, 362);
            this.lblVersaoDll.Name = "lblVersaoDll";
            this.lblVersaoDll.Size = new System.Drawing.Size(40, 13);
            this.lblVersaoDll.TabIndex = 3;
            this.lblVersaoDll.Text = "Versão";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(12, 90);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 4;
            this.lblFeedback.Text = "Feedback";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Entrar sem iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSala
            // 
            this.lstSala.FormattingEnabled = true;
            this.lstSala.Location = new System.Drawing.Point(10, 19);
            this.lstSala.Name = "lstSala";
            this.lstSala.Size = new System.Drawing.Size(178, 69);
            this.lstSala.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListarJogadores);
            this.groupBox4.Controls.Add(this.btnIniciarPartida);
            this.groupBox4.Controls.Add(this.lstSala);
            this.groupBox4.Location = new System.Drawing.Point(12, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 155);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sala";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(10, 94);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(178, 23);
            this.btnListarJogadores.TabIndex = 12;
            this.btnListarJogadores.Text = "Listar jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Enabled = false;
            this.btnIniciarPartida.Location = new System.Drawing.Point(10, 123);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(178, 23);
            this.btnIniciarPartida.TabIndex = 11;
            this.btnIniciarPartida.Text = "Iniciar";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(6, 93);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboDebug);
            this.groupBox5.Controls.Add(this.lblTimer);
            this.groupBox5.Controls.Add(this.lblFeedback);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(222, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 151);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // cboDebug
            // 
            this.cboDebug.FormattingEnabled = true;
            this.cboDebug.Location = new System.Drawing.Point(9, 19);
            this.cboDebug.Name = "cboDebug";
            this.cboDebug.Size = new System.Drawing.Size(175, 21);
            this.cboDebug.TabIndex = 14;
            this.cboDebug.DropDown += new System.EventHandler(this.cboDebug_DropDown);
            this.cboDebug.SelectedIndexChanged += new System.EventHandler(this.cboDebug_SelectedIndexChanged);
            // 
            // FrmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 381);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblVersaoDll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLobby";
            this.Text = "Lobby - Fukushima";
            this.Load += new System.EventHandler(this.FrmLobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TextBox txtEntrarSenha;
        private System.Windows.Forms.TextBox txtEntrarNome;
        private System.Windows.Forms.Label lblIdEntrarPartida;
        private System.Windows.Forms.TextBox txtEntrarId;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblVersaoDll;
        private System.Windows.Forms.Label lblSenhaCriarPartida;
        private System.Windows.Forms.TextBox txtCriarNome;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtCriarSenha;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSala;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboDebug;
    }
}

