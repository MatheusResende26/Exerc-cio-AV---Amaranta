namespace DataGridView
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.piccertoS = new System.Windows.Forms.PictureBox();
            this.piccertoU = new System.Windows.Forms.PictureBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.picsenha = new System.Windows.Forms.PictureBox();
            this.picusuario = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(139, 40);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(148, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.Txtusuario_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(139, 128);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '•';
            this.txtsenha.Size = new System.Drawing.Size(148, 20);
            this.txtsenha.TabIndex = 2;
            this.txtsenha.TextChanged += new System.EventHandler(this.Txtsenha_TextChanged);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(72, 45);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 15);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.lblsenha.Location = new System.Drawing.Point(86, 130);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(47, 15);
            this.lblsenha.TabIndex = 4;
            this.lblsenha.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.piccertoS);
            this.groupBox1.Controls.Add(this.piccertoU);
            this.groupBox1.Controls.Add(this.btnentrar);
            this.groupBox1.Controls.Add(this.picsenha);
            this.groupBox1.Controls.Add(this.picusuario);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Location = new System.Drawing.Point(48, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login e senha";
            // 
            // piccertoS
            // 
            this.piccertoS.Image = global::DataGridView.Properties.Resources.certo_png;
            this.piccertoS.Location = new System.Drawing.Point(293, 130);
            this.piccertoS.Name = "piccertoS";
            this.piccertoS.Size = new System.Drawing.Size(23, 18);
            this.piccertoS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccertoS.TabIndex = 9;
            this.piccertoS.TabStop = false;
            this.piccertoS.Visible = false;
            // 
            // piccertoU
            // 
            this.piccertoU.Image = global::DataGridView.Properties.Resources.certo_png;
            this.piccertoU.Location = new System.Drawing.Point(293, 40);
            this.piccertoU.Name = "piccertoU";
            this.piccertoU.Size = new System.Drawing.Size(23, 18);
            this.piccertoU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccertoU.TabIndex = 8;
            this.piccertoU.TabStop = false;
            this.piccertoU.Visible = false;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnentrar.Location = new System.Drawing.Point(178, 192);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(92, 37);
            this.btnentrar.TabIndex = 7;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Visible = false;
            this.btnentrar.Click += new System.EventHandler(this.Btnentrar_Click);
            this.btnentrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btnentrar_MouseUp);
            // 
            // picsenha
            // 
            this.picsenha.Image = global::DataGridView.Properties.Resources.senha;
            this.picsenha.Location = new System.Drawing.Point(28, 117);
            this.picsenha.Name = "picsenha";
            this.picsenha.Size = new System.Drawing.Size(38, 31);
            this.picsenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsenha.TabIndex = 6;
            this.picsenha.TabStop = false;
            // 
            // picusuario
            // 
            this.picusuario.BackgroundImage = global::DataGridView.Properties.Resources.administrador;
            this.picusuario.Image = global::DataGridView.Properties.Resources.administrador;
            this.picusuario.Location = new System.Drawing.Point(28, 31);
            this.picusuario.Name = "picusuario";
            this.picusuario.Size = new System.Drawing.Size(38, 32);
            this.picusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picusuario.TabIndex = 5;
            this.picusuario.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picusuario;
        private System.Windows.Forms.PictureBox picsenha;
        private System.Windows.Forms.PictureBox piccertoU;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.PictureBox piccertoS;
    }
}

