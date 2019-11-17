using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciciosAula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------Bem-Vindo ao Console!--------------------------------------");
            Console.Write("Digite seu primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Digite Sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite seu CPF com \".\" e \"-\":");
            string cpf = Console.ReadLine();
            Console.WriteLine($"Cadastro Realizado com sucesso! \nNome: {nome} \nSobrenome: {sobrenome} \nIdade: {idade} \nCPF: {cpf}");
            Console.WriteLine("Aperte\"Enter\" para SAIR");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            Console.Read();//manter console aberto
        }
    }
}