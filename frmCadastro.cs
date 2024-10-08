using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void valida_dados()
        {
            bool erro = false;

            if (txtUser.TextLength < 3)
            {
                erro = true;
            }

            if (txtUsername.TextLength < 4)
            {
                erro = true;
            }

            if (txtSenha.TextLength < 5)
            {
                erro = true;
            }

            if (txtSenha.Text == txtRepeteSenha.Text) 
            {
                erro = true;
            }

            if (erro == true) 
            {
                btnLogin.Enabled = true;

            }
            
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            valida_dados();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            valida_dados();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            valida_dados();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            valida_dados();
        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {
            valida_dados();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}