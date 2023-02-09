using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 13 - Investimento a Longo Prazo:");

        double investimento = 1000, rentabilidade = 1.005;

        for (int ano = 1; ano <= 5; ano++) {
            for (int mes = 1; mes <= 12; mes++) {
                investimento *= rentabilidade;
            }
            rentabilidade += 0.001;
        }

        // se quisermos usar as variáveis ano e mês
        // na linha abaixo, o programa não compilaria
        // pois o escopo de ambas pertence ao seu
        // respectivo for.
        Console.WriteLine("Após 5 anos: R$" + investimento);

        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}
