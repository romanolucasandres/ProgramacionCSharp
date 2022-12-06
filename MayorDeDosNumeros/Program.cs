Console.WriteLine("Digite el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el segundo numero");
int num2 = int.Parse(Console.ReadLine());

int mayor;

if (num1 > num2)
{
    mayor = num1;
}
else
{
    mayor = num2;
}
Console.WriteLine("El mayor de " + num1 + " y " + num2 + " es: " + mayor);