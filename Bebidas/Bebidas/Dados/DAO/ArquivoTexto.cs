using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.DAO
{
    public class ArquivoTexto
    {
        string caminho = @"C:\CSharpF\Pessoas.txt";

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
            while (arquivo.EndOfStream == false)
            {
                string linha = arquivo.ReadLine();
                string[] pessoaLinha = linha.Split(';');
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = pessoaLinha[0];
                pessoa.Sobrenome = pessoaLinha[1];
                pessoa.CPF = pessoaLinha[2];
                lista.Add(pessoa);
            }
            arquivo.Close();
            return lista;
        }

    }
}
