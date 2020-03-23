namespace DataGridView
{
    partial class formulario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpreencherCPF = new System.Windows.Forms.TextBox();
            this.txtpreencherRG = new System.Windows.Forms.TextBox();
            this.txtpreencheNome = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btcadastrarF = new System.Windows.Forms.Button();
            this.mtxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtrg = new System.Windows.Forms.MaskedTextBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbmsim = new System.Windows.Forms.RadioButton();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnecessidade = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNecEspeciais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpreencherCPF);
            this.groupBox1.Controls.Add(this.txtpreencherRG);
            this.groupBox1.Controls.Add(this.txtpreencheNome);
            this.groupBox1.Controls.Add(this.btnexcluir);
            this.groupBox1.Controls.Add(this.btcadastrarF);
            this.groupBox1.Controls.Add(this.mtxtcpf);
            this.groupBox1.Controls.Add(this.mtxtrg);
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.rbmsim);
            this.groupBox1.Controls.Add(this.cmbsexo);
            this.groupBox1.Controls.Add(this.dtpDataNascimento);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.lblnecessidade);
            this.groupBox1.Controls.Add(this.lblrg);
            this.groupBox1.Controls.Add(this.lblsexo);
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(33, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pessoas";
            // 
            // txtpreencherCPF
            // 
            this.txtpreencherCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpreencherCPF.ForeColor = System.Drawing.Color.DarkRed;
            this.txtpreencherCPF.Location = new System.Drawing.Point(259, 257);
            this.txtpreencherCPF.Name = "txtpreencherCPF";
            this.txtpreencherCPF.Size = new System.Drawing.Size(132, 13);
            this.txtpreencherCPF.TabIndex = 17;
            this.txtpreencherCPF.Text = "Preenchimento obrigatório";
            this.txtpreencherCPF.TextChanged += new System.EventHandler(this.TxtpreencherCPF_TextChanged);
            // 
            // txtpreencherRG
            // 
            this.txtpreencherRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpreencherRG.ForeColor = System.Drawing.Color.DarkRed;
            this.txtpreencherRG.Location = new System.Drawing.Point(259, 207);
            this.txtpreencherRG.Name = "txtpreencherRG";
            this.txtpreencherRG.Size = new System.Drawing.Size(132, 13);
            this.txtpreencherRG.TabIndex = 16;
            this.txtpreencherRG.Text = "Preenchimento obrigatório";
            this.txtpreencherRG.TextChanged += new System.EventHandler(this.TxtpreencherRG_TextChanged);
            // 
            // txtpreencheNome
            // 
            this.txtpreencheNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpreencheNome.ForeColor = System.Drawing.Color.DarkRed;
            this.txtpreencheNome.Location = new System.Drawing.Point(385, 35);
            this.txtpreencheNome.Name = "txtpreencheNome";
            this.txtpreencheNome.Size = new System.Drawing.Size(132, 13);
            this.txtpreencheNome.TabIndex = 15;
            this.txtpreencheNome.Text = "Preenchimento obrigatório";
            this.txtpreencheNome.Visible = false;
            this.txtpreencheNome.TextChanged += new System.EventHandler(this.TxtpreencheNome_TextChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(186, 291);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(78, 28);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // btcadastrarF
            // 
            this.btcadastrarF.Location = new System.Drawing.Point(60, 291);
            this.btcadastrarF.Name = "btcadastrarF";
            this.btcadastrarF.Size = new System.Drawing.Size(106, 28);
            this.btcadastrarF.TabIndex = 13;
            this.btcadastrarF.Text = "Cadastrar";
            this.btcadastrarF.UseVisualStyleBackColor = true;
            this.btcadastrarF.Visible = false;
            this.btcadastrarF.Click += new System.EventHandler(this.BtcadastrarF_Click);
            // 
            // mtxtcpf
            // 
            this.mtxtcpf.Location = new System.Drawing.Point(60, 250);
            this.mtxtcpf.Mask = "999.999.999-99";
            this.mtxtcpf.Name = "mtxtcpf";
            this.mtxtcpf.Size = new System.Drawing.Size(196, 20);
            this.mtxtcpf.TabIndex = 12;
            this.mtxtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtxtcpf_MaskInputRejected);
            // 
            // mtxtrg
            // 
            this.mtxtrg.Location = new System.Drawing.Point(60, 200);
            this.mtxtrg.Mask = "99.999.999.9";
            this.mtxtrg.Name = "mtxtrg";
            this.mtxtrg.Size = new System.Drawing.Size(196, 20);
            this.mtxtrg.TabIndex = 11;
            this.mtxtrg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtxtrg_MaskInputRejected);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(259, 157);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbmsim
            // 
            this.rbmsim.AutoSize = true;
            this.rbmsim.Location = new System.Drawing.Point(186, 157);
            this.rbmsim.Name = "rbmsim";
            this.rbmsim.Size = new System.Drawing.Size(42, 17);
            this.rbmsim.TabIndex = 9;
            this.rbmsim.TabStop = true;
            this.rbmsim.Text = "Sim";
            this.rbmsim.UseVisualStyleBackColor = true;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Location = new System.Drawing.Point(68, 117);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(160, 21);
            this.cmbsexo.TabIndex = 8;
            this.cmbsexo.SelectedIndexChanged += new System.EventHandler(this.Cmbsexo_SelectedIndexChanged);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(139, 69);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(103, 20);
            this.dtpDataNascimento.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(28, 250);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 5;
            this.lblcpf.Text = "CPF:";
            // 
            // lblnecessidade
            // 
            this.lblnecessidade.AutoSize = true;
            this.lblnecessidade.Location = new System.Drawing.Point(28, 161);
            this.lblnecessidade.Name = "lblnecessidade";
            this.lblnecessidade.Size = new System.Drawing.Size(131, 13);
            this.lblnecessidade.TabIndex = 4;
            this.lblnecessidade.Text = "Necessidades Especiais?:";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(28, 203);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(26, 13);
            this.lblrg.TabIndex = 3;
            this.lblrg.Text = "RG:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(28, 120);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 2;
            this.lblsexo.Text = "Sexo:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(28, 75);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(105, 13);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "Data de nascimento:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(28, 31);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDataNascimento,
            this.colSexo,
            this.colCPF,
            this.colRG,
            this.colNecEspeciais});
            this.dgvClientes.Location = new System.Drawing.Point(5, 392);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(648, 89);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.Name = "colName";
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colRG
            // 
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            // 
            // colNecEspeciais
            // 
            this.colNecEspeciais.HeaderText = "Necessidades Especiais";
            this.colNecEspeciais.Name = "colNecEspeciais";
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 510);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formulario";
            this.Text = "formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btcadastrarF;
        private System.Windows.Forms.MaskedTextBox mtxtcpf;
        private System.Windows.Forms.MaskedTextBox mtxtrg;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbmsim;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnecessidade;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNecEspeciais;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.TextBox txtpreencheNome;
        private System.Windows.Forms.TextBox txtpreencherCPF;
        private System.Windows.Forms.TextBox txtpreencherRG;
    }
}