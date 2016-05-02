using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.util.importacao
{
    class ImportacaoDados
    {
        private string Arquivo;
        private TiposImportacao Tipo;

        public ImportacaoDados(TiposImportacao Tipo, string Arquivo)
        {
            this.Tipo = Tipo;
            this.Arquivo = Arquivo;
        }

        public int importar()
        {
            switch (Tipo)
            {
                case TiposImportacao.Autor:
                    return importaAutor();
                case TiposImportacao.Emprestimo:
                    return importaAutor();
                case TiposImportacao.Exemplar:
                    return importaAutor();
                case TiposImportacao.Livro:
                    return importaAutor();
                case TiposImportacao.Multa:
                    return importaAutor();
                case TiposImportacao.Perfil:
                    return importaAutor();
                case TiposImportacao.Usuário:
                    return importaAutor();
                default:
                    return 0;
            }


            
        }

        private int importaAutor()
        {
            System.IO.StreamReader f = new System.IO.StreamReader(Arquivo);
            String line;
            int quantosAutores = 0;
            using (bibliotecaEntities b = new bibliotecaEntities())
            {
             
                while ((line = f.ReadLine()) != null)
                {
                    AUTOR a = new AUTOR();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.nome = line.Substring(12);
                    b.AUTOR.Add(a);
                    quantosAutores++;
                }
                b.SaveChanges();
             
            }
            return quantosAutores;
        }
    }
}
