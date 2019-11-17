using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Contexto
{
    public class BebidasContexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public BebidasContexto() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\GitHub\CursoCSharp\CursoCSharpF\Bebidas\Bebidas\Dados\BancoDeDados\Banco.mdf;Integrated Security=True")
        {

        }

    }
}
