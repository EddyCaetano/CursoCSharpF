using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bebidas.ConsoleApp.Classes;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Loja de Bebidas *****");
            Console.WriteLine("Bem-Vindo a loja");

            Dados dados = new Dados();
           
            for (int i=0; i<2; i++)
            {
                Pessoa p = CadastrarCliente();
                dados.Salvar(p);
            }
            //listaClientes = listaClientes.OrderBy(i => i).ToList();//sistema de ordenação de lista
            List<Pessoa> listaClientes = dados.LerTodos();
            foreach (Pessoa item in listaClientes)
            {
                Console.WriteLine($"Nome completo: {item.Nome} {item.Sobrenome}");
            }
            
            Console.Read();//não fechar o console
        }
        static Pessoa CadastrarCliente()
        {
            Pessoa pessoa1 = new Pessoa();
            Console.Write("Digite o seu nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite o seu Sobrenome: ");
            pessoa1.Sobrenome = Console.ReadLine();
            //tring nomeCompleto = $"{pessoa1.Nome} {pessoa1.Sobrenome}";
            return pessoa1;

        }
    }
}
