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
    public partial class MultaObservacaoView : Form
    {
        private int id;
        public MultaObservacaoView()
        {
            InitializeComponent();
        }
        public MultaObservacaoView(int id, string observacao):this()
        {
            this.id = id;
            txtObservacao.Text = observacao;
        }

        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            Controller.MultaController c = new Controller.MultaController();
            var m = c.getMultaByID(id);
            m.observacao = txtObservacao.Text;
            c.persist(m);
            this.Close();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
