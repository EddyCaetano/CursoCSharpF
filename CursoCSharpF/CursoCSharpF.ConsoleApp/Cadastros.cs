using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Cadastros
    {
        public static string CadastroPessoa()
        {
            Console.WriteLine("========================Cadastro de Pessoa========================");
            Console.Write("Escreva seu nome: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Escreva seu Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Escreva sua idede: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==================================================================");

            //========= Imprimindo com concatenação
            //Console.WriteLine("O nome é: " + primeiroNome + " Sobrenome " + sobrenome + " Idade: " + idade);
            //========= Imprimindo com interpolação de strings
            //Console.WriteLine($"O nome é: {primeiroNome} Sobrenome {sobrenome} Idade: {idade}");
            string pessoa = $"O nome é: {primeiroNome} Sobrenome {sobrenome} Idade: {idade}";
            return pessoa;
        }
    }
}
