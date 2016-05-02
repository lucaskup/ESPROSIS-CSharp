using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.util.importacao
{
    public partial class ViewImportar : Form
    {
        public ViewImportar()
        {
            InitializeComponent();
            cbTipo.DataSource = Enum.GetValues(typeof(TiposImportacao));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportacaoDados i = new ImportacaoDados((TiposImportacao)cbTipo.SelectedItem, txtArquivo.Text);
            i.importar();


        }

        private void txtArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                OpenFileDialog f = new OpenFileDialog();
                f.ShowDialog();
                txtArquivo.Text = f.FileName;
            }
        }
    }
}
