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
    public partial class ExemplarViewEditar : Form
    {
        private EXEMPLAR exemplar;
        public ExemplarViewEditar()
        {
            InitializeComponent();
        }
        public ExemplarViewEditar(int id, bool perdido, int tipo, int fkLivro) : this()
        {
            txtId.Text = id.ToString();
            chkPerdido.Checked = perdido;
            cbTipo.SelectedIndex = tipo-1;
            cbLivro.SelectedValue = fkLivro;
            
        }

        private void ExemplarViewEditar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.LIVRO' table. You can move, or remove it, as needed.
            this.lIVROTableAdapter.Fill(this.bibliotecaDataSet.LIVRO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.AUTOR' table. You can move, or remove it, as needed.
            //this.aUTORTableAdapter.Fill(this.bibliotecaDataSet.AUTOR);

        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            ExemplarController c = new ExemplarController();
            this.exemplar = new EXEMPLAR();

            if (!txtId.Text.Equals(string.Empty))
                exemplar.id = int.Parse(txtId.Text);

            exemplar.perdido = chkPerdido.Checked;
            exemplar.tipo = (TipoExemplar)(int.Parse(cbTipo.Text.Substring(0,1)));
            exemplar.fkLivro = (int)cbLivro.SelectedValue;
      
            c.persist(exemplar);
            this.Close();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
