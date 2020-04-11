namespace PI3___Fukushima
{
    partial class frmTabuleiro
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
            this.pcbParede = new System.Windows.Forms.PictureBox();
            this.pcbModelo = new System.Windows.Forms.PictureBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbParede
            // 
            this.pcbParede.BackgroundImage = global::PI3___Fukushima.Properties.Resources.A8nlUrz;
            this.pcbParede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbParede.Location = new System.Drawing.Point(437, 68);
            this.pcbParede.Name = "pcbParede";
            this.pcbParede.Size = new System.Drawing.Size(341, 341);
            this.pcbParede.TabIndex = 3;
            this.pcbParede.TabStop = false;
            // 
            // pcbModelo
            // 
            this.pcbModelo.BackgroundImage = global::PI3___Fukushima.Properties.Resources.P06wHU3;
            this.pcbModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbModelo.Image = global::PI3___Fukushima.Properties.Resources.P06wHU3;
            this.pcbModelo.Location = new System.Drawing.Point(34, 44);
            this.pcbModelo.Name = "pcbModelo";
            this.pcbModelo.Size = new System.Drawing.Size(374, 374);
            this.pcbModelo.TabIndex = 2;
            this.pcbModelo.TabStop = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Image = global::PI3___Fukushima.Properties.Resources.P06wHU3;
            this.lblModelo.Location = new System.Drawing.Point(114, 228);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(341, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbParede);
            this.Controls.Add(this.pcbModelo);
            this.Controls.Add(this.lblModelo);
            this.DoubleBuffered = true;
            this.Name = "frmTabuleiro";
            this.Text = "frmTabuleiro";
            this.Load += new System.EventHandler(this.frmTabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbParede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.PictureBox pcbModelo;
        private System.Windows.Forms.PictureBox pcbParede;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}