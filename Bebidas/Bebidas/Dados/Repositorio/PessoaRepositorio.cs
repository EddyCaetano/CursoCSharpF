using Dados.Contexto;
using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class PessoaRepositorio
    {
        public List<Pessoa> ListarTodos()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            using (BebidasContexto contexto = new BebidasContexto())
            {
                listaPessoas = contexto.Pessoa.ToList();
            }
            return listaPessoas;
        }
        public void Salvar(Pessoa pessoa)
        {
            using (BebidasContexto contexto = new BebidasContexto())
            {
                contexto.Pessoa.Add(pessoa);
                contexto.SaveChanges();
            }
        }
    }
}
