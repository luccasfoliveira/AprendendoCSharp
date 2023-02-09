using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("11 - Projeto - Calcular Poupança (while):");

        int mes = 1;
        double investimento = 1000;

        // invertimento de 0.05%
        while (mes <= 12) {
            investimento *= 1.005;
            Console.WriteLine("Mês: " + mes + " - Rendeu: R$" + investimento);
            mes++;
        }

        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}
