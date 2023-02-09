using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 12 - Caclular a Poupança (for):");

        double investimento = 1000;

        for (int i = 1; i <= 12; i++) {
            investimento *= 1.005;
            Console.WriteLine("Mês: " + i + " - Retorno: R$" + investimento);
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
