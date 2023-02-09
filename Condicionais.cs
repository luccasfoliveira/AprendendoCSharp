using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 7 - Condicionais:");

        int idade = 15, quantidadePessoas = 3;

        if (idade > 17) {
            Console.WriteLine("Pode entrar ;)");
        }
        else {
            if (quantidadePessoas > 1) {
                // testando a instrução @ antes de começar o valor da string
                Console.WriteLine(@"Pode entrar
pois está acompanhado... :)");
            }
            else {
                Console.WriteLine("Não tem permissão para entrar :(");
            }
        }
        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}
