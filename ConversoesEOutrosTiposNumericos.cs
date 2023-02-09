using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 04 - Conversoes E Outros Tipos Numericos");

        float tipoFlutuante = 3.14f; // pi
        double salario = 1270.50, valor1 = 0.2, valor2 = 0.1, total;

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro); // 1270

        total = valor1 + valor2;
        Console.WriteLine(total);

        Console.WriteLine("Valor Tipo Flutuante: " + tipoFlutuante);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}
