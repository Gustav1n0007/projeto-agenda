using System.Drawing.Text;

namespace projeto_agenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void validar_login()
        {
            // && funciona como um AND no python
            if (txtUser.TextLength > 3 && txtSenha.TextLength > 8)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
          validar_login();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
          validar_login();
        }
    }
}
