using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp.Classes
{
    class Dados
    {
        string caminho = @"C:\CSharpF\Pessoas.txt";
        #region Metodos
        public void Salvar(Pessoa pessoa)
        {
            StreamWriter arquivo = File.AppendText(caminho);
            arquivo.WriteLine(pessoa);
            arquivo.Close();
        }

        public List<Pessoa> LerTodos()
        {
            List<Pessoa> lista = new List<Pessoa>();

            StreamReader arquivo = File.OpenText(caminho);
            while (arquivo.EndOfStream != true)
            {
                string linha = arquivo.ReadLine();
                string[] linhaQuebrada = linha.Split(';');

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = linhaQuebrada[0];
                pessoa.Sobrenome = linhaQuebrada[1];

                lista.Add(pessoa);

            }

            return lista;
        }
        #endregion
    }
}
