using Biblioteca.Controller;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class LoginView : Form
    {
        internal USUARIO u;

        public LoginView()
        {
            InitializeComponent();
        }

        public LoginView(USUARIO u):this()
        {
            this.u = u;
        }

        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioController c = new UsuarioController();
            u = c.login(txtLogin.Text, txtSenha.Text);
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
