using System;

namespace FixicacaoAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Em que ano você nasceu? ");
            int ano = int.Parse(Console.ReadLine());
                int idade = (2020 - ano);

            if(idade >=18){
                Console.WriteLine("Pode votar!");
            }
            else {
                Console.WriteLine("De acordo com a sua idade, não esta apto para votar.");
            }
        }
    }
}
