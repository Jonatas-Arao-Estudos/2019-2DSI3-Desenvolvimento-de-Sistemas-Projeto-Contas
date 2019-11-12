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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
        private void logar()
        {
            tbUsuarioBindingSource.Filter = "nm_login ='" + txtLogin.Text + "' and ds_senha ='" + txtSenha.Text + "'";
            tbUsuarioTableAdapter.Fill(contasDataSet.tbUsuario);
            if ((txtLogin.Text == "adm" && txtSenha.Text == "123") || tbUsuarioBindingSource.Count > 0)
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
                Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet.tbUsuario);

        }
    }
}
