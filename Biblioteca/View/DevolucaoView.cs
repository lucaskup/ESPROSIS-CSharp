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
    public partial class DevolucaoView : Form
    {
        private Controller.EmprestimoController c = new Controller.EmprestimoController();
        private EMPRESTIMO emprestimo;
        public DevolucaoView()
        {
            InitializeComponent();
        }

        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            c.devolver(emprestimo);
            atualizarTela();
     
        }

        private void txtExemplar_TextChanged(object sender, EventArgs e)
        {
            emprestimo = c.getEmprestimo(int.Parse(txtExemplar.Text));
            if(emprestimo != null)
            {
                lblExemplar.Text = "Data empréstimo: " + emprestimo.dtEmprestimo.ToShortDateString() + " Livro " + emprestimo.EXEMPLAR.LIVRO.titulo;
            }
            else
            {
                lblExemplar.Text = String.Empty;
            }
            
        }

        private void DevolucaoView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.MULTA' table. You can move, or remove it, as needed.
            this.mULTATableAdapter.Fill(this.bibliotecaDataSet.MULTA);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.EMPRESTIMO' table. You can move, or remove it, as needed.
            this.eMPRESTIMOTableAdapter.Fill(this.bibliotecaDataSet.EMPRESTIMO);

        }
        private void atualizarTela()
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.MULTA' table. You can move, or remove it, as needed.
            this.mULTATableAdapter.Fill(this.bibliotecaDataSet.MULTA);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.bibliotecaDataSet.USUARIO);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.EMPRESTIMO' table. You can move, or remove it, as needed.
            this.eMPRESTIMOTableAdapter.Fill(this.bibliotecaDataSet.EMPRESTIMO);
        }
    }
}
