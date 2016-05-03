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
                    return importaEmprestimo();
                case TiposImportacao.Exemplar:
                    return importaExemplar();
                case TiposImportacao.Livro:
                    return importaLivro();
                case TiposImportacao.Multa:
                    return importaMulta();
                case TiposImportacao.Perfil:
                    return importaPerfil();
                case TiposImportacao.Usuário:
                    return importaUsuario();
                default:
                    return 0;
            }



        }

        private int importaUsuario()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    USUARIO a = new USUARIO();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.nome = line.Substring(12, 50).Trim();
                    a.sobrenome = line.Substring(63, 50).Trim();
                    a.dtNascimento = DateTime.ParseExact(line.Substring(114, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    a.fkPerfil = int.Parse(line.Substring(125, 11).Trim());
                    a.senha = line.Substring(137).Trim();
                    b.USUARIO.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaPerfil()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    PERFIL a = new PERFIL();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.nome = line.Substring(12, 50).Trim();
                    a.qtLivros = int.Parse(line.Substring(64, 10));
                    a.diasParaEmprestimo = int.Parse(line.Substring(76, 10));
                    a.valorMulta = decimal.Parse(line.Substring(87).Replace('.', ',').Trim());
                    b.PERFIL.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaMulta()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    MULTA a = new MULTA();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.valor = decimal.Parse(line.Substring(12, 14).Replace('.', ',').Trim());
                    a.vencimento = DateTime.ParseExact(line.Substring(27, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    a.abonado = line.Substring(38, 1).Trim() == "T";

                    b.MULTA.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaLivro()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    LIVRO a = new LIVRO();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.titulo = line.Substring(12, 50).Trim();
                    a.fkAutor = int.Parse(line.Substring(64, 10));
                    a.isbn = line.Substring(75).Trim();
                    b.LIVRO.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaExemplar()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    EXEMPLAR a = new EXEMPLAR();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.perdido = line.Substring(12, 1).Trim() == "T";
                    a.tipo = (TipoExemplar)int.Parse(line.Substring(15, 1));
                    a.fkLivro = int.Parse(line.Substring(17).Trim());
                    b.EXEMPLAR.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaEmprestimo()
        {
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
                {
                    EMPRESTIMO a = new EMPRESTIMO();
                    a.id = int.Parse(line.Substring(0, 11));
                    a.dtEmprestimo = DateTime.ParseExact(line.Substring(12, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    a.dtPrazoDevolucao = DateTime.ParseExact(line.Substring(23, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime dataDevolucao;
                    DateTime.TryParseExact(line.Substring(34, 10), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dataDevolucao);
                    if (dataDevolucao != DateTime.MinValue)
                    {
                        a.dtDevolucao = dataDevolucao;
                    }
                    a.fkUsuario = int.Parse(line.Substring(45, 11));
                    a.fkExemplar = int.Parse(line.Substring(57, 11));
                    int idMulta = int.Parse(line.Substring(69, 11));
                    if(idMulta != 0)
                    {
                        a.fkMulta = idMulta;
                    }

                    b.EMPRESTIMO.Add(a);
                }
                b.SaveChanges();

            }
            return linhas.Length;
        }

        private int importaAutor()
        {
            int quantosAutores = 0;
            var linhas = System.IO.File.ReadAllLines(Arquivo, Encoding.GetEncoding(1252));

            using (bibliotecaEntities b = new bibliotecaEntities())
            {

                foreach (var line in linhas)
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
