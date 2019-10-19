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
    public partial class frmPesquisaContasReceber : Form
    {
        public frmPesquisaContasReceber()
        {
            InitializeComponent();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbContasReceberBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbContasReceberBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet.tbContasReceber);

        }
        private void tbContasReceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmContasReceber.codigo = int.Parse(tbContasReceberDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                tbContasReceberTableAdapter.Fill(contasDataSet.tbContasReceber);
            }
            else
            {
                tbContasReceberTableAdapter.FillByCodigo(contasDataSet.tbContasReceber, int.Parse(txtCodigo.Text));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
