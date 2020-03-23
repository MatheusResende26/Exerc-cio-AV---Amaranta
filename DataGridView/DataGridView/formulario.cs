using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class formulario : Form
    {
        List<pessoa> lista = new List<pessoa>();
        
        public formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            sexo objsexo = new sexo();
            cmbsexo.DataSource = objsexo.listar();
            cmbsexo.ValueMember = "id"; 
            cmbsexo.DisplayMember = "descricao";
        }

        private void BtcadastrarF_Click(object sender, EventArgs e)
        {
            pessoa Pessoa = new pessoa();
            Pessoa.Nome = txtNome.Text;

            sexo Sexo = new sexo();
            if(cmbsexo.SelectedIndex == 1)
            {
                Pessoa.Sexo = "Masculino";
            }
            else
            {
                Pessoa.Sexo = "Feminino";
            }

            Pessoa.DataNascimento = dtpDataNascimento.Text;
            if (rbmsim.Checked)
            {
                Pessoa.NecessidadesEspeciais = true;
            }
            else
            {
                Pessoa.NecessidadesEspeciais = false;
            }
            Pessoa.RG = mtxtrg.Text;
            Pessoa.CPF = mtxtcpf.Text;

            lista.Add(Pessoa);
            DataGridView1();
            limpaCampos();
        }
        public void limpaCampos()
        {
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cmbsexo.Text = "";
            if (rbmsim.Checked)
            {
                rbmsim.Checked = false;
            }
            else
            {
                rbNao.Checked = false;
            }
            mtxtcpf.Clear();
            mtxtrg.Clear();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void DataGridView1()
        {
            dgvClientes.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == "Feminino"? "Feminino" :  "Masculino",
                    lista[i].CPF,
                    lista[i].RG,
                    lista[i].NecessidadesEspeciais == false ? "Não": "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }

        }

        private void Cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<sexo> sexos = new List<sexo>();
            sexos.Add(new sexo(1, "Feminino", "F"));
            sexos.Add(new sexo(2, "Masculino", "M"));
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            int indicelinha = dgvClientes.CurrentRow.Index;
            
            limpaCampos();
            dgvClientes.Rows.Clear();
            lista.RemoveAt(indicelinha);
            DataGridView1();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                txtpreencheNome.Visible = true;
                MessageBox.Show("O campo Nome deve ser preenchido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                txtpreencheNome.Visible = false;
            }
            verificar();
        }
    
        private void Mtxtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            if (mtxtrg.Mask =="")
            {
                txtpreencherRG.Visible = true;
                MessageBox.Show("O campo RG deve ser preenchido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtrg.Focus();
            }
            else
            {
                txtpreencherRG.Visible = false;
            }
            verificar();
        }
        private void Mtxtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtcpf.Mask == "")
            {
                txtpreencherCPF.Visible = true;
                MessageBox.Show("O campo CPF deve ser preenchido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtcpf.Focus();
            }
            else
            {
                txtpreencherCPF.Visible = false;
            }
            verificar();
        }
        public void verificar()
        {
            if (txtpreencheNome.Visible || txtpreencherCPF.Visible || txtpreencherRG.Visible) 
            {
                btcadastrarF.Visible =  false;
            }
            else
            {
                btcadastrarF.Visible = true;
            }
        }
        private void Txtpreenchersexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtpreencherCPF_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void TxtpreencheNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtpreencherRG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
