using System;

class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 14 - Horas e Minutos:");

        int horas, minutos;

        for (horas = 0; horas <= 12; horas++) {
            for (minutos = 0; minutos <= 59; minutos++) {
                Console.WriteLine(horas + ":" + minutos);
            }
        }
        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}
