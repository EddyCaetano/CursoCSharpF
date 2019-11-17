using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Modelo
{
    public class Pessoa
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        #endregion
        #region Metodos
        public override string ToString()
        {
            return $"{Nome};{Sobrenome};{CPF}";
        }

        #endregion
    }
}
