using System;
class Programa
{
    static void Main(string[] args) {
        Console.WriteLine("Projeto 15 - Mexnedo com o For:");
        //*
        //**
        //***
        //****
        //*****
        //******
        //*******
        //********
        //*********
        //**********

        for (int i = 1; i <= 9; i++) {
            for (int j = 0; j < i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
