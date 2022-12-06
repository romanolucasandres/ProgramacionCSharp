using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Bienvenidx a TU CALCULADORA");
Console.WriteLine("---------------------------");
Console.WriteLine(" ");
Console.WriteLine("Digite el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el segundo numero");
int num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;

int resta = num1 - num2;

int multiplicacion = num1 * num2;




Console.WriteLine("La Suma es igual a: " + suma);
Console.WriteLine("La Resta es igual a: " + resta);
Console.WriteLine("La Multiplicacion es igual a: " + multiplicacion);
if (num2 == 0)
{
    Console.WriteLine("ERROR! No se puede dividir por 0");
}
else
{
    int division = num1 / num2;

    Console.WriteLine("La division es igual a: " + division);
}