using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Loja de Bebidas *****");
            Console.WriteLine("Bem-Vindo a loja");

            List<string> listaClientes = new List<string>();

            for (int i=0; i<3; i++)
            {
                string nc = CadastrarCliente();
                listaClientes.Add(nc);
            }
            //listaClientes = listaClientes.OrderBy(i => i).ToList();//sistema de ordenação de lista
            foreach (string item in listaClientes)
            {
                Console.WriteLine($"Nome: {item}");
            }
            
            Console.Read();
        }
        static string CadastrarCliente()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o seu Sobrenome: ");
            string sobrenome = Console.ReadLine();
            string nomeCompleto = $"{nome} {sobrenome}";

            return nomeCompleto;
        }
    }
}
