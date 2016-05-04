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
                    multa.ID = em.MULTA.id;
                    multa.Nome = em.USUARIO.nome.Trim()+" "+em.USUARIO.sobrenome.Trim();
                    multa.Observacao = em.MULTA.observacao;
                    multa.Valor = em.MULTA.valor;
                    multa.Vencimento = em.MULTA.vencimento.Value;
                    multa.Abonado = em.MULTA.abonado;
                    listaMultas.Add(multa);
                }
            }
            gridMulta.DataSource = listaMultas;
            gridMulta.ReadOnly = true;
        }

        private struct MultaGrid
        {
            public int ID { get; set; }
            public DateTime Vencimento { get; set; }
            public decimal Valor { get; set; }
            public string Nome { get; set; }
            public bool Abonado { get; set; }
            public string Observacao { get; set; }
        }

        private int getIDSelecionado()
        {
            if(gridMulta.CurrentRow!=null)
                return (int)gridMulta.CurrentRow.Cells[0].Value;
            return 0;
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
            if(m != null)
            {
                MultaObservacaoView vw = new MultaObservacaoView(m.id, m.observacao);
                vw.ShowDialog();
                atualizaTela();
            }
            
        }


    }
}
