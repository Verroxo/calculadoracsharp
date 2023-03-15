// See https://aka.ms/new-console-template for more information


// Usando o sistema dotnet.
using System;

// Classe de Programa.
class Program{


    // fazer o começo do int do C em c#.
    static void Main(string[] args){


        // Basicamente fazer o printf e scanf.
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());


        // Basicamente fazer o printf e scanf2.
        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());


        // Resultado
        double result = num1 + num2;


        // Printf do nosso resultado.
        Console.WriteLine("O resultado disso é " + result);

    }

}