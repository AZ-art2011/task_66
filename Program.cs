//Задача 66. Задайте значения M и N. Найдите сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Укажите гранницы диапазона.");
Console.WriteLine("Нижняя M:");
int NumM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Верхняя N:");
int NumN = Convert.ToInt32(Console.ReadLine());

void NumSum (int NumM, int NumN, int sum)
{
    if (NumM > NumN) 
    {
        Console.WriteLine($"Сумма элементов в указанном диапазоне: {sum}"); 
        return;
    }
    sum = sum + (NumM++);
    NumSum(NumM, NumN, sum);
}

NumSum(NumM, NumN, 0);
