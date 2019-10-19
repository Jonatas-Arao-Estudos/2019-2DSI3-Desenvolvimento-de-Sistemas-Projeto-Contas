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
    public partial class frmPesquisaFornecedor : Form
    {
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.contasDataSet.tbFornecedor);

        }
        private void tbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmFornecedor.codigo = int.Parse(tbFornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                tbFornecedorTableAdapter.Fill(contasDataSet.tbFornecedor);
            }
            else
            {
                tbFornecedorTableAdapter.FillByNome(contasDataSet.tbFornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
