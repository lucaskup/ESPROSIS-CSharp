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
    public partial class ExemplarView : Form
    {
        public ExemplarView()
        {
            InitializeComponent();
            
        }

        private void ExemplarView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LIVRO' table. You can move, or remove it, as needed.
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LIVRO' table. You can move, or remove it, as needed.
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.EXEMPLAR' table. You can move, or remove it, as needed.
            this.eXEMPLARTableAdapter.Fill(this.bibliotecaDataSet.EXEMPLAR);

        }

        private void pbExcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("O processo de exclusão é irreversivel, confirma excluir?", " ", MessageBoxButtons.OKCancel);
            if (r.Equals(DialogResult.OK))
            {
                Biblioteca.Controller.ExemplarController c = new Controller.ExemplarController();
                c.delete((int)gridAutor.CurrentRow.Cells[0].Value);
                atualizaTela();
            }
        }

        private void atualizaTela()
        {
            this.eXEMPLARTableAdapter.Fill(this.bibliotecaDataSet.EXEMPLAR);
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            ExemplarViewEditar vw = new ExemplarViewEditar(((int)gridAutor.CurrentRow.Cells[0].Value), (bool)gridAutor.CurrentRow.Cells[1].Value, (int)gridAutor.CurrentRow.Cells[2].Value, (int)gridAutor.CurrentRow.Cells[3].Value);
            vw.ShowDialog();
            atualizaTela();
        }

        private void pbCriar_Click(object sender, EventArgs e)
        {
            ExemplarViewEditar vw = new ExemplarViewEditar();
            vw.ShowDialog();
            atualizaTela();
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
