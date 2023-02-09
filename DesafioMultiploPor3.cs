using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Desafio 16 - Multiplo de 03");
        Console.WriteLine("Imprimir os multiplos de 3");

        for (int i = 3; i <= 100; i += 3) {
            Console.WriteLine(i);
        }

        Console.WriteLine(("Tecle Enter para sair..."));
        Console.ReadLine();
    }
}
