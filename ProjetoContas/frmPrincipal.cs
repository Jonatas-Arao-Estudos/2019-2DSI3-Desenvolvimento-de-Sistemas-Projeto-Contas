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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasReceber fcr = new frmContasReceber();
            fcr.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar fcp = new frmContasPagar();
            fcp.Show();
        }

        private void remessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemessa frr = new frmRemessa();
            frr.Show();
        }

        private void retornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetorno frr = new frmRetorno();
            frr.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario fru = new frmRelatorioUsuario();
            fru.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente frc = new frmRelatorioCliente();
            frc.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor frf = new frmRelatorioFornecedor();
            frf.Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioContasReceber frcr = new frmRelatorioContasReceber();
            frcr.Show();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioContasPagar frcp = new frmRelatorioContasPagar();
            frcp.Show();
        }
    }
}
