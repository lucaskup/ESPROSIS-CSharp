using Biblioteca.Controller;
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
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
        }

        private void UsuarioView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.PERFIL' table. You can move, or remove it, as needed.
            this.pERFILTableAdapter.Fill(this.bibliotecaDataSet.PERFIL);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("O processo de exclusão é irreversivel, confirma excluir?", " ", MessageBoxButtons.OKCancel);
            if (r.Equals(DialogResult.OK))
            {
                UsuarioController c = new UsuarioController();
                c.delete((int)gridPerfil.CurrentRow.Cells[0].Value);
                atualizaTela();
            }

        }

        private void atualizaTela()
        {
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);
        }

        private void pbCriar_Click(object sender, EventArgs e)
        {
            UsuarioViewEditar vw = new UsuarioViewEditar();
            vw.ShowDialog();
            atualizaTela();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            UsuarioViewEditar vw = new UsuarioViewEditar(((int)gridPerfil.CurrentRow.Cells[0].Value));
            vw.ShowDialog();
            atualizaTela();
        }
    }
}
