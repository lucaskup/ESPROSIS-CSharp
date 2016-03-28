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
    public partial class UsuarioViewEditar : Form
    {
        private USUARIO user = new USUARIO();

        public UsuarioViewEditar()
        {
            InitializeComponent();

        }

        public UsuarioViewEditar(int id):this()
        {
            UsuarioController c = new UsuarioController();
            user = c.getByID(id);

        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            USUARIO u = new USUARIO();
            if(!txtId.Text.Equals(string.Empty))
                u.id = int.Parse(txtId.Text);
            u.nome = txtNome.Text;
            u.sobrenome = txtSobrenome.Text;
            u.senha = txtSenha.Text;
            u.dtNascimento = dPckDataNascimento.Value;
            u.fkPerfil = (int)cbPerfil.SelectedValue;

            var c = new Controller.UsuarioController();
            c.persist(u);
            this.Close();

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioViewEditar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.PERFIL' table. You can move, or remove it, as needed.
            this.pERFILTableAdapter.Fill(this.bibliotecaDataSet.PERFIL);
            if(user.id != 0)
                txtId.Text = user.id.ToString();
            txtNome.Text = user.nome;
            txtSenha.Text = user.senha;
            txtSobrenome.Text = user.sobrenome;
            dPckDataNascimento.Value = user.dtNascimento;

            cbPerfil.SelectedValue = user.fkPerfil;


        }
    }
}
