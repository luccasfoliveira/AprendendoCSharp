using System;

class Programa
{
    static void Main(string[] args) {
        double n1, n2, media;
        n1 = 9.0;
        n2 = 8.9;
        media = (n1 + n2) / 2;

        // seguindo os comentários abaixo,
        // se esta variável não foi declarada no início,
        // mas sim dentro de condicionais, ela perde a visibilidade global
        string status;

        if (media >= 7) {
            // string status = "aprovado"; erro de compilação
            status = "aprovado";
        }
        else {
            // string status = "reprovado"; erro de compilação
            status = "reprovado";
        }

        // só irá funcionar se a variável estiver com a visibilidade; acesso global
        Console.WriteLine(status);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}
