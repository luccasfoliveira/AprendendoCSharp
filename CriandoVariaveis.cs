using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 2 - Criando Variáveis:");

        int idade;
        idade = 27;
        Console.WriteLine("Minha idade: " + idade);

        idade += 1;
        Console.WriteLine("Minha idade ano que vem: " + idade);

        Console.Write("Esta função não realiza a quebra de linha --> ");

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
