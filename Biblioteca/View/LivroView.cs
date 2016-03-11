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
    public partial class LivroView : Form
    {
        public LivroView()
        {
            InitializeComponent();
        }

        private void LivroView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.AUTOR' table. You can move, or remove it, as needed.
            this.aUTORTableAdapter.Fill(this.bibliotecaDataSet.AUTOR);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LIVRO' table. You can move, or remove it, as needed.
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);

        }

        private void pbCriar_Click(object sender, EventArgs e)
        {
            var vw = new LivroViewEditar();
            vw.ShowDialog();
            atualizaTela();
        }

        private void atualizaTela()
        {
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            var livro = new LIVRO();
            livro.id = (int)gridLivros.CurrentRow.Cells[0].Value;
            livro.titulo = (string)gridLivros.CurrentRow.Cells[1].Value;
            livro.fkAutor = (int)gridLivros.CurrentRow.Cells[2].Value;
            livro.isbn = (string)gridLivros.CurrentRow.Cells[3].Value;

            var vw = new LivroViewEditar(livro);
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
                Biblioteca.Controller.LivroController c = new Controller.LivroController();
                c.delete((int)gridLivros.CurrentRow.Cells[0].Value);
                atualizaTela();
            }
        }
    }
}
