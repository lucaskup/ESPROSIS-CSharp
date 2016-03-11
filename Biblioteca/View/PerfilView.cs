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
    public partial class PerfilView : Form
    {
        public PerfilView()
        {
            InitializeComponent();
        }

        private void PerfilView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.PERFIL' table. You can move, or remove it, as needed.
            this.pERFILTableAdapter.Fill(this.bibliotecaDataSet.PERFIL);

        }
        private void atualizaTela()
        {
            this.pERFILTableAdapter.Fill(this.bibliotecaDataSet.PERFIL);
        }

        private void pbCriar_Click(object sender, EventArgs e)
        {
            PerfilViewEditar vw = new PerfilViewEditar();
            vw.ShowDialog();
            atualizaTela();

        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            PerfilViewEditar vw = new PerfilViewEditar(((int)gridPerfil.CurrentRow.Cells[0].Value), (string)gridPerfil.CurrentRow.Cells[1].Value, (int)gridPerfil.CurrentRow.Cells[2].Value, (int)gridPerfil.CurrentRow.Cells[3].Value, (decimal)gridPerfil.CurrentRow.Cells[4].Value);
            vw.ShowDialog();
            atualizaTela();
        }

        private void pbExcluir_Click(object sender, EventArgs e)
        {
            PerfilController c = new PerfilController();
            c.delete((int)gridPerfil.CurrentRow.Cells[0].Value);
            atualizaTela();
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
