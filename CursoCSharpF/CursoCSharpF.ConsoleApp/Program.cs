using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nome = Cadastros.CadastroPessoa();
            //Console.WriteLine( nome);

            //int idade = RetornaIdade();
            //Console.WriteLine(idade);
            //Console.ReadLine();
            Console.Write("Digite um Valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um outro Valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("________________________________________________");

            int numero = Soma(n1, n2);
            Console.WriteLine($"A soma é {numero}");

            numero = Divi(n1, n2);
            Console.WriteLine($"A divisão é {numero}");
           
            numero = Mult(n1, n2);
            Console.WriteLine($"A Multiplicação é {numero}");
            

            numero = Modulo(n1, n2);
            Console.WriteLine($"A sovbra da divisão é {numero}");


            Console.ReadLine();
        }

        static int Soma(int numero1, int numero2)
        {

            int soma = numero1 + numero2;

            return soma;

        }
        static int Divi(int numero1, int numero2)
        {

            int divi = numero1 / numero2;

            return divi;
        }
        static int Mult(int numero1, int numero2)
        {

            int mult = numero1 * numero2;

            return mult;
        }
        static int Modulo(int numero1, int numero2)
        {

            int modulo = numero1 % numero2;

            return modulo;
        }
    }
}
