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
    public partial class PerfilViewEditar : Form
    {
        private int value;

        public PerfilViewEditar()
        {
            InitializeComponent();
        }

        public PerfilViewEditar(int id, string nome, int qtdLivros, int diasEmprestimo, decimal valorMulta):this()
        {
            var perfil = new PERFIL();
            perfil.id = id;
            perfil.nome = nome;
            perfil.qtLivros = qtdLivros;
            perfil.diasParaEmprestimo = diasEmprestimo;
            perfil.valorMulta = valorMulta;

            txtId.Text = perfil.id.ToString();
            txtNome.Text = perfil.nome;
            txtQtdLivros.Text = perfil.qtLivros.ToString();
            txtDiasEmprestimo.Text = perfil.valorMulta.ToString();
            txtDiasEmprestimo.Text = perfil.diasParaEmprestimo.ToString();

        }



        private void pbSalvar_Click(object sender, EventArgs e)
        {
            var perfil = new PERFIL();
            if (!txtId.Text.Equals(string.Empty))
                perfil.id = int.Parse(txtId.Text);
            perfil.nome = txtNome.Text;
            perfil.qtLivros = int.Parse(txtQtdLivros.Text);
            perfil.valorMulta = decimal.Parse(txtValorMulta.Text);
            perfil.diasParaEmprestimo = int.Parse(txtDiasEmprestimo.Text);
            PerfilController c = new PerfilController();
            c.persist(perfil);
            this.Close();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
