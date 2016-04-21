using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class MainView : Form
    {
        LoginView vw;
        USUARIO usuarioLogado;
        public MainView()
        {
            InitializeComponent();
        }

        private void pbAutor_Click(object sender, EventArgs e)
        {
            AutorView vw = new AutorView();
            vw.Show();
        }

        private void pbLivro_Click(object sender, EventArgs e)
        {
            LivroView vw = new LivroView();
            vw.Show();
        }

        private void pbExemplar_Click(object sender, EventArgs e)
        {
            ExemplarView vw = new ExemplarView();
            vw.Show();
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            PerfilView vw = new PerfilView();
            vw.Show();
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            UsuarioView vw = new UsuarioView();
            vw.Show();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            usuarioLogado = new USUARIO();
            vw = new LoginView();
            vw.ShowDialog();
            if(vw.u != null)
            {
                usuarioLogado = vw.u;
                lblUsuario.Text = "Usuário Logado: " + usuarioLogado.nome;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            
        }

        private void pbEmprestimo_Click(object sender, EventArgs e)
        {
            EmprestimoView vw = new EmprestimoView(usuarioLogado);
            vw.Show();
        }

        private void pbDevolucao_Click(object sender, EventArgs e)
        {
            DevolucaoView vw = new DevolucaoView();
            vw.Show();
        }

        private void pbMulta_Click(object sender, EventArgs e)
        {
            MultaView vw = new MultaView();
            vw.Show();
        }

        #region Controle do Cursor do Mouse

        private void pbAutor_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbAutor_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbLivro_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbLivro_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbExemplar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbExemplar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbPerfil_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbPerfil_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbEmprestimo_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbEmprestimo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbDevolucao_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbDevolucao_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbMulta_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbMulta_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        #endregion
    }
}
