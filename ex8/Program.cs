Console.WriteLine("Введите конечное значение диапазона 1...N");
int n = int.Parse(Console.ReadLine());
    if (n > 1)
    {
      int i = 4;
      Console.Write(n + "-> 2");
    while (i <= n) 
    {
       Console.Write("," + i);
       i=i+2;
    } 
    Console.WriteLine("");
    }
    else
    {
       Console.WriteLine("Положительных четных чисел меньше 1 не существует"); 
    }
     
    


