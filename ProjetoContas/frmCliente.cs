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
    public partial class frmCliente : Form
    {
        public static int codigo;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }
        private void Habilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Desabilita();
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.contasDataSet.tbCliente);

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbClienteBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbClienteBindingSource.EndEdit();
            tbClienteTableAdapter.Update(this.contasDataSet.tbCliente);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
            {
                tbClienteBindingSource.RemoveCurrent();
                tbClienteTableAdapter.Update(contasDataSet.tbCliente);
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
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            if (codigo > 0)
            {
                reg = tbClienteBindingSource.Find("cd_cliente", codigo);
                tbClienteBindingSource.Position = reg;
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
            
            strDados = "FICHA DE CLIENTE\n" + (char)10;
            strDados += "Código: " + cd_clienteTextBox.Text + (char)10;
            strDados += "Nome: " + nm_clienteTextBox.Text + (char)10;
            strDados += "Endereço: " + ds_enderecoTextBox.Text + (char)10;
            strDados += "Cidade: " + nm_cidadeTextBox.Text + (char)10;
            strDados += "Bairro: " + nm_bairroTextBox.Text + (char)10;
            strDados += "Estado: " + sg_estadoTextBox.Text + (char)10;
            strDados += "CEP: " + cd_cepTextBox.Text + (char)10;
            strDados += "Nível: " + ds_telefoneTextBox.Text + (char)10;
            strDados += "Email: " + ds_emailTextBox.Text + (char)10;
            strDados += "Tipo: " + sg_tipoTextBox.Text + (char)10;
            strDados += "CPF: " + cd_cpfTextBox.Text + (char)10;
            strDados += "CNPJ: " + cd_rgTextBox.Text + (char)10;
            strDados += "IE: " + cd_ieTextBox.Text;
            objImpressao.DrawString(strDados, new System.Drawing.Font("Corbel", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }



    }
}
