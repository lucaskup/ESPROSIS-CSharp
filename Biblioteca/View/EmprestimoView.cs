﻿using Biblioteca.Controller;
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
    public partial class EmprestimoView : Form
    {
        private ExemplarController c = new ExemplarController();
        private EXEMPLAR exemplarDigitando;
        private USUARIO usuarioLogado;
        




        public EmprestimoView()
        {
            InitializeComponent();
        }

        public EmprestimoView(USUARIO usuarioLogado):this()
        {
            this.usuarioLogado = usuarioLogado;           
        }

        private void txtEmprestimo_TextChanged(object sender, EventArgs e)
        {
            int id;
            exemplarDigitando = null;
            lblNomeLivro.Text = String.Empty;
            // Busca um exemplar com o id digitado
            if (int.TryParse(txtEmprestimo.Text, out id))
            {
                exemplarDigitando = c.getByID(id);
                //atualiza label com o titulo do livro
                if (exemplarDigitando != null)
                    lblNomeLivro.Text = exemplarDigitando.LIVRO.titulo;

            }
            
        }

        private void pbIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.registrarEmprestimo(exemplarDigitando, usuarioLogado);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            

        }
    }
}
