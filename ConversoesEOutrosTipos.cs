using System;
using System.Transactions;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 04 - Conversões e Outros Tipos:");

        double salario;
        salario = 1375.10;
        Console.WriteLine("Salário em Decimal: " + salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine("Salário em Inteiro: " + salarioInteiro);

        // Outros tipos de dados:

        long a = 20000000000000000;
        short b = 1500;
        float c = 1.90f;

        Console.WriteLine("Long: " + a);
        Console.WriteLine("Short: " + b);
        Console.WriteLine("Float: " + c);


        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
