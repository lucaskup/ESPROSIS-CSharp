using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Controller;

namespace Biblioteca.View
{
    public partial class LivroViewEditar : Form
    {
        private LIVRO livro;
        
        private LivroController livroControl = new LivroController();
        public LivroViewEditar()
        {
            InitializeComponent();
        }

        public LivroViewEditar(LIVRO livro):this()
        {
            this.livro = livro;
                    
        }

        private void LivroViewEditar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.AUTOR' table. You can move, or remove it, as needed.
            this.aUTORTableAdapter.Fill(this.bibliotecaDataSet.AUTOR);
            txtId.Text = livro.id.ToString();
            txtTitulo.Text = livro.titulo;
            txtISBN.Text = livro.isbn;
            cbAutor.SelectedValue = livro.fkAutor;
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            var livro = new LIVRO();
            if (!txtId.Text.Equals(string.Empty))
                livro.id = int.Parse(txtId.Text);

            livro.titulo = txtTitulo.Text;
            livro.isbn = txtISBN.Text;

            livro.fkAutor = (int)cbAutor.SelectedValue;

            livroControl.persist(livro);
            this.Close();
        }
    
    }
}
