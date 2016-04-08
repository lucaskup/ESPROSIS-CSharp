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
    public partial class MultaView : Form
    {
        private Controller.MultaController c = new Controller.MultaController();
        public MultaView()
        {
            InitializeComponent();

        }

        private void MultaView_Load(object sender, EventArgs e)
        {
            atualizaTela();
        }

        private void atualizaTela()
        {
            List<MultaGrid> listaMultas = new List<MultaGrid>();
            using (var db = new bibliotecaEntities())
            {
                var lista = (from em in db.EMPRESTIMO
                             where em.fkMulta != null
                             select em);

                foreach (var em in lista)
                {
                    MultaGrid multa = new MultaGrid();
                    multa.id = em.MULTA.id;
                    multa.nome = em.USUARIO.nome;
                    multa.titulo = em.EXEMPLAR.LIVRO.titulo;
                    multa.observacao = em.MULTA.observacao;
                    multa.valor = em.MULTA.valor;
                    multa.dtPrazo = em.MULTA.vencimento.Value;
                    multa.abonado = em.MULTA.abonado;
                    listaMultas.Add(multa);
                }
            }
            gridMulta.DataSource = listaMultas;
            gridMulta.ReadOnly = true;
        }

        private struct MultaGrid
        {
            public int id { get; set; }
            public DateTime dtPrazo { get; set; }
            public decimal valor { get; set; }
            public String nome { get; set; }
            public String titulo { get; set; }
            public bool abonado { get; set; }
            public String observacao { get; set; }
        }

        private int getIDSelecionado()
        {
            return (int)gridMulta.CurrentRow.Cells[0].Value;
        }

        private void pbAbonar_Click(object sender, EventArgs e)
        {
            c.abonar(getIDSelecionado());
            atualizaTela();
        }

        private void pbPagar_Click(object sender, EventArgs e)
        {
            c.pagar(getIDSelecionado());
            atualizaTela();
        }

        private void pbObservacao_Click(object sender, EventArgs e)
        {
            var m = c.getMultaByID(getIDSelecionado());
            MultaObservacaoView vw = new MultaObservacaoView(m.id, m.observacao);
            vw.ShowDialog();
            atualizaTela();
        }
    }
}
