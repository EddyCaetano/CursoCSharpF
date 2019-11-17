using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Calendario
    {
        bool diaFora = false;
        int dia;

        public void diaSemana()
        {
            Console.WriteLine("Digite um dia");
            while (dia > 31 || dia < 1)
            {
                int dia = Convert.ToInt32(Console.ReadLine());
            }
            

        }
    }
}
