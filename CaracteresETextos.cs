using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 05 - Carateres e Textos:");

        char letra = 'a';
        Console.WriteLine("Caracter: " + letra);

        // há posibilidades de realizar operações diante da tabela ASCII
        Console.WriteLine("Usando a Função (char):");
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(85 - 5);
        Console.WriteLine(letra);


        string primeiraFrase = "Luccas Oliveira ";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine(primeiraFrase + 2023);


        string vazia = "";
        Console.WriteLine("String Vazia: " + vazia);

        string cursosFATEC = @"Cursos da FATEC GARÇA:
    Análie e Desenvolvimento de Sistemas
    Mecatrônica Industrial
    Gertão EMpresarial";

        Console.WriteLine(cursosFATEC);

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}
