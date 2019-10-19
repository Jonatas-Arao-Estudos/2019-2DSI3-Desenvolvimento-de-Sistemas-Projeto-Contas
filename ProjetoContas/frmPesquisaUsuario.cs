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
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void TbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void TbUsuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet.tbUsuario);

        }

        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmUsuario.codigo = int.Parse(tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                tbUsuarioTableAdapter.Fill(contasDataSet.tbUsuario);
            }
            else
            {
                tbUsuarioTableAdapter.FillByNome(contasDataSet.tbUsuario, "%" + txtNome.Text + "%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
