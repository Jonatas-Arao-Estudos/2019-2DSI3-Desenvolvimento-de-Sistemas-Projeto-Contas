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
                + linha.ToString("000000")
           );
            int rr = 0;
            DataRowView drc, drcr;
            while (rr < tbContasReceberBindingSource.Count)
            {
                drcr = (DataRowView)tbContasReceberBindingSource.Current;
                int codeli = int.Parse(drcr["id_cliente"].ToString());
                int reg = tbClienteBindingSource.Find("cd_cliente", codeli);
                tbClienteBindingSource.Position = reg;
                drc = (DataRowView)tbClienteBindingSource.Current;
                arq.WriteLine("100000 00000000000000190161000012345"
                    + drcr["cd_contareceber"].ToString().PadRight(25)
                    + "23720200"
                    + NossoNumero(drcr["cd_contareceber"].ToString().PadLeft(11, '0'))
                    + "00000000002N           2  01"
                    + drcr["cd_contareceber"].ToString().PadRight(10)
                    + drcr["dt_vencimento"].ToString().Substring(0, 2)
                    + drcr["dt_vencimento"].ToString().Substring(3, 2)
                    + drcr["dt_vencimento"].ToString().Substring(8, 2)
                    + (double.Parse(drcr["vl_conta"].ToString()) * 100).ToString().PadLeft(13, '0')
                    + "000000001N"
                    + drcr["dt_emissao"].ToString().Substring(0, 2)
                    + drcr["dt_emissao"].ToString().Substring(3, 2)
                    + drcr["dt_emissao"].ToString().Substring(8, 2)
                    + "    0000000000000000000000000000000000000000000000000000000000"
                    + (drc["sg_tipo"].ToString() == "F" ? "01" + drc["cd_cpf"].ToString().PadLeft(14, '0') : "01" + drc["cd_cnpj"].ToString().PadLeft(14, '0'))
                    + drc["nm_cliente"].ToString().PadRight(40)
                    + drc["ds_endereco"].ToString().PadRight(40)
                    + "            "
                    + drc["cd_cep"].ToString().PadLeft(8, '0')
                    + "                                                            "
                    + linha.ToString().PadLeft(6, '0')
                );
                rr++;
                if (rr < tbContasReceberBindingSource.Count)
                {
                    tbContasReceberBindingSource.MoveNext();
                }
            }
            linha++;
            arq.WriteLine("9                                                                                                                                                                                                                                                                                                                                                                                                         " + linha.ToString().PadLeft(6, '0'));
            arq.Close();
        }

        private string NossoNumero(string nn)
        {
            nn = "19" + nn;
            return nn;
        }

    }
}
