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
    public partial class frmRelatorioContasReceber : Form
    {
        public frmRelatorioContasReceber()
        {
            InitializeComponent();
        }

        private void frmRelatorioContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet.tbContasReceber);

            this.reportViewer1.RefreshReport();
        }
    }
}
