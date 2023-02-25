Console.WriteLine("Введите число 1- ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2- ");
int numberB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3- ");
int numberC= Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > numberB) max = numberA;
else
{
    if(numberB > numberC) max = numberB;
    else max = numberC;
}
Console.Write("Максимальное число - ");
Console.WriteLine(max);