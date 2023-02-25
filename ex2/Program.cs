Console.WriteLine("Введите число 1- ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2- ");
int numberB= Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > numberB) max = numberA;
if (numberB > numberA) max = numberB;
Console.Write("Максимальное число - ");
Console.WriteLine(max);