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
    public partial class frmPesquisaContasPagar : Form
    {
        public frmPesquisaContasPagar()
        {
            InitializeComponent();
        }

        private void tbContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbContasPagarBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet.tbContasPagar);

        }
        private void tbContasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmContasPagar.codigo = int.Parse(tbContasPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                tbContasPagarTableAdapter.Fill(contasDataSet.tbContasPagar);
            }
            else
            {
                tbContasPagarTableAdapter.FillByCodigo(contasDataSet.tbContasPagar, int.Parse(txtCodigo.Text));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
