Console.WriteLine("Введите число 1- ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2- ");
int numB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3- ");
int numC= Convert.ToInt32(Console.ReadLine());
int max = numA;
if (numA > numB) max = numA;
else
{
    if(numB > numC) max = numB;
    else max = numC;
}
Console.WriteLine("Максимальное число " + "->" + max);
