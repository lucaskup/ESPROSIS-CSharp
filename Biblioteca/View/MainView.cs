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
    }
}
