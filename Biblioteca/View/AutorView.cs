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
    public partial class AutorView : Form
    {
        public AutorView()
        {
            InitializeComponent();
        }

        private void AutorView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.AUTOR' table. You can move, or remove it, as needed.
            atualizaTela();

        }

        private void pbCriar_Click(object sender, EventArgs e)
        {
            AutorViewEditar vw = new AutorViewEditar();
            vw.ShowDialog();
            atualizaTela();

        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            
            AutorViewEditar vw = new AutorViewEditar(((int)gridAutor.CurrentRow.Cells[0].Value), (string)gridAutor.CurrentRow.Cells[1].Value);
            vw.ShowDialog();
            atualizaTela();
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
                Biblioteca.Controller.AutorController c = new Controller.AutorController();
                c.delete((int)gridAutor.CurrentRow.Cells[0].Value);
                atualizaTela();
            }
        }

        private void atualizaTela()
        {
            this.aUTORTableAdapter.Fill(this.bibliotecaDataSet.AUTOR);
        }

        private void gridAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
