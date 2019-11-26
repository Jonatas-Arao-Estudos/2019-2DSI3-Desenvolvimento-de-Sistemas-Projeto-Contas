using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoContas
{
    public partial class frmRemessa : Form
    {
        public frmRemessa()
        {
            InitializeComponent();
        }

        private void frmRemessa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet.tbContasReceber);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.contasDataSet.tbCliente);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int remessa = 1, linha = 1;
            string dtInicial, dataHoje;
            dtInicial = dtpInicial.Text;
            dataHoje = DateTime.Now.ToShortDateString();
            dataHoje = dataHoje.Substring(0, 2) + dataHoje.Substring(3, 2) + dataHoje.Substring(8, 2);
            tbContasReceberBindingSource.Filter = "dt_emissao>='" + dtInicial + "'";
            tbContasReceberTableAdapter.Fill(contasDataSet.tbContasReceber);
            StreamWriter arq = new StreamWriter(@"C:\Bradesco\CB" + dataHoje.PadLeft(4) + "01.REM");
            arq.WriteLine("01REMESSA01COBRANCA       00000000000000123456ETEC ITANHAEM                 237BRADESCO       " 
                + dataHoje 
                + "        MX" 
                + remessa.ToString("0000000") 
                + "                                                                                                                                                                                                                                                                                     " 
                + linha.ToString("000000"));
            while (tbContasReceberBindingSource.Position < tbContasReceberBindingSource.Count)
            {
                string nossonumero = contasDataSet.tbContasReceber.Rows[tbContasReceberBindingSource.Position][contasDataSet.tbContasReceber.cd_contaColumn].ToString().PadRight(11,'0');
                arq.WriteLine("100000 00000000000000190161000012345"
                    + contasDataSet.tbContasReceber.Rows[tbContasReceberBindingSource.Position][contasDataSet.tbContasReceber.cd_contaColumn].ToString().PadRight(25)
                    + "23720200" + nossonumero
                    );
            }
        }
    }
}
