using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmFornecedor : Form
    {
        public static int codigo;
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbFornecedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }
        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void Desabilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            Desabilita();
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.contasDataSet.tbFornecedor);

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbFornecedorBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbFornecedorBindingSource.EndEdit();
            tbFornecedorTableAdapter.Update(this.contasDataSet.tbFornecedor);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFornecedorBindingSource.Count > 0)
            {
                tbFornecedorBindingSource.RemoveCurrent();
                tbFornecedorTableAdapter.Update(contasDataSet.tbFornecedor);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frmPesquisaFornecedor fpf = new frmPesquisaFornecedor();
            fpf.ShowDialog();
            if (codigo > 0)
            {
                reg = tbFornecedorBindingSource.Find("cd_Fornecedor", codigo);
                tbFornecedorBindingSource.Position = reg;
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE FORNECEDOR\n" + (char)10;
            strDados += "Código: " + cd_fornecedorTextBox.Text + (char)10;
            strDados += "Nome: " + nm_fornecedorTextBox.Text + (char)10;
            strDados += "Endereço: " + ds_enderecoTextBox.Text + (char)10;
            strDados += "Cidade: " + nm_cidadeTextBox.Text + (char)10;
            strDados += "Bairro: " + nm_bairroTextBox.Text + (char)10;
            strDados += "Estado: " + sg_estadoTextBox.Text + (char)10;
            strDados += "CEP: " + cd_cepTextBox.Text + (char)10;
            strDados += "Nível: " + ds_telefoneTextBox.Text + (char)10;
            strDados += "Email: " + ds_emailTextBox.Text;
            objImpressao.DrawString(strDados, new System.Drawing.Font("Corbel", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }
    }
}
