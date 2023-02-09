using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 8 - Condicionais - Operador Lógico: or; ou; || e and; e; &&:");

        int idade = 16, quantidadePessoa = 3;

        // este tipo de dado guarda valores true ou false
        bool acompanhado = quantidadePessoa > 1;

        // com o operador lógico || uma das condições tem que ser verdade
        Console.WriteLine("Usando o Operador Lógico ||:");

        // ***** IMPORTANTE *****
        // quando a instrução if ou else houver uma linha de código
        // após a expresão, não há necessidade abrir chaves,
        // consequentemente fechar a mesma.

        if (idade > 17 || acompanhado)
            Console.WriteLine("Pode entrar :)");
     
        else 
            Console.WriteLine("Não pode entrar :(");


        // com o operador lógico && ambas tem que satisfazer (verdade)
        Console.WriteLine("Usando o Operador Lógico &&:");
        if (idade > 17 && acompanhado)
            Console.WriteLine("Pode entrar :)");

        else 
            Console.WriteLine("Não pode entrar :(");
            Console.WriteLine("Teste");
        
        

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}