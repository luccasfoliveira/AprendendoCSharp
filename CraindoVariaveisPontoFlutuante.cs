using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 3 - Criando Variáveis Ponto Flutuante");

        double salario, idade, x;
        salario = 1300.33;
        idade = 27.0;

        x = 10 / 5;
        Console.WriteLine(x);

        Console.WriteLine(salario);
        Console.WriteLine(idade);

        x = 10.0 / 3;
        Console.WriteLine(x);

        x = idade / 27;
        Console.WriteLine(x);

        Console.WriteLine("Precione Enter para sair...");
        Console.ReadLine();
    }
}
