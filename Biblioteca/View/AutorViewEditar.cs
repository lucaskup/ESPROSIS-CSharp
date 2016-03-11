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
    public partial class AutorViewEditar : Form
    {
        private AutorController autorControl = new AutorController();


        public AutorViewEditar()
        {
            InitializeComponent();
        }

        public AutorViewEditar(int id, string nome):this()
        {
            
            //this.txtId = new TextBox();
            this.txtId.Text = id.ToString();
            this.txtNome.Text = nome;
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            var autor = new AUTOR();
            if (!txtId.Text.Equals(string.Empty))
                autor.id = int.Parse(txtId.Text);

            autor.nome = txtNome.Text;
            autorControl.persist(autor);
            this.Close();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
