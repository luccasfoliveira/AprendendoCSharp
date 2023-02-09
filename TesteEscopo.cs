using System;

class Programa {
    static void Main(string[] args) {
        Console.WriteLine("Projeto 10 - Testanto Escopos:");

        int idade = 16;
        int qntPessoas = 1;

        bool acompanhado = qntPessoas > 1;

        if (acompanhado || idade > 17)
            Console.WriteLine("Pode entrar");

        else 
            Console.WriteLine("Não pode entrar");

        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}
