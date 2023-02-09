using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 17 - Desafio Fatorial (01-10):");
            
        for (int i = 1; i <= 10; i++) {
            int fatorial = 1;
            for (int j = 1;j < i+1; j++) {
                fatorial *= j;
            }
            Console.WriteLine(fatorial);
        }
        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}
