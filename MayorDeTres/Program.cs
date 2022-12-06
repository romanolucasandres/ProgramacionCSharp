Console.WriteLine("Digite el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el segundo numero");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el segundo numero");
int num3 = int.Parse(Console.ReadLine());

int mayor;

if (num1 > num2 && num1 > num3)
{
    mayor = num1;
}
else if (num1 < num2 && num2 > num3)
{
    mayor = num2;
}
else
{
    mayor = num3;
}
Console.WriteLine("El mayor de " + num1 + ", " + num2 + " y " + num3 + " es: " + mayor);