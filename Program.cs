void NewTask()
{
    System.Console.WriteLine("Нажмите Enter для продолжения и перехода к следующей задаче");
    Console.ReadLine();
    Console.Clear();
}
int GetValue(string message = "")
{
    System.Console.WriteLine($"Введите значение {message}: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int PrintValues(int first, int second)
{
    if (first > second)
    {
        System.Console.Write($"{first}, ");
        return PrintValues(first - 1, second);
    }
    else if (first < second)
    {
        System.Console.Write($"{first}, ");
        return PrintValues(first + 1, second);
    }
    else
        System.Console.WriteLine(first);
    return second;
}
Console.Clear();
System.Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
int m = GetValue("M");
int n = GetValue("N");
PrintValues(m, n);

NewTask();
System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int GetSum(int first, int second)
{
    if (first > second)
    {
        return first + GetSum(first - 1, second);

    }
    else if (first < second)
    {
        return first + GetSum(first + 1, second);
    }
    else
        return first;

}

m = GetValue("M");
n = GetValue("N");
System.Console.WriteLine(GetSum(m, n));
NewTask();
System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
m = GetValue("M");
while (m < 0)
{
    System.Console.WriteLine("M должно быть больше 0");
    m = GetValue("M");
}
n = GetValue("N");
while (n < 0)
{
    System.Console.WriteLine("N должно быть больше 0");
    n = GetValue("N");
}


int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}
System.Console.WriteLine(Akkerman(m, n));

