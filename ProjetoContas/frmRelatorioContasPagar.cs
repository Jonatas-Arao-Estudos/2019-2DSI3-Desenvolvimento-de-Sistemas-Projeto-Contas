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
    public partial class frmRelatorioContasPagar : Form
    {
        public frmRelatorioContasPagar()
        {
            InitializeComponent();
        }

        private void frmRelatorioContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet.tbContasPagar);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
