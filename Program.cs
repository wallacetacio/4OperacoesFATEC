// See https://aka.ms/new-console-template for more information
// Usando o VScode, contém template para programação em c# assim fica implicito as seguintes linhas: 
/*using System;

namespace 4OperascoesFatec
{
    class Program
    {
        static void Main(string[] args)
        { 
	}
     }
}*/
double n1,n2,resultado;

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

resultado = n1 + n2;
Console.WriteLine("A soma dos dois números é igual a: " + resultado);
Console.WriteLine("");

resultado = n1 - n2;
Console.WriteLine("A subtração dos dois números é igual a: " + resultado);
Console.WriteLine("");

resultado = n1 * n2;
Console.WriteLine("A multiplicação dos dois números é igual a: " + resultado);
Console.WriteLine("");

resultado = n1 / n2;
Console.WriteLine("A divisão dos dois números é igual a: " + resultado);
Console.WriteLine("Aperte qualquer tecla para sair...");
Console.ReadKey();