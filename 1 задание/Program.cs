/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите числа через пробел: ");
string numbers = Console.ReadLine();
if (numbers == "")
{
    Console.WriteLine("Ввели пустую строку");
}
else
{
    string[] num = numbers.Split(' ');
    if (num.try)
    int[] ints = Array.ConvertAll(num, s => int.Parse(s));
    int positive = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (ints[i] > 0)
        {
            positive += 1;
        }
    }

    if (positive > 0)
    {
        Console.WriteLine($"Вы ввели {positive} чисел больше ноля");
    }
    else
    {
        Console.WriteLine("Вы не ввели ни одного числа, больше ноля");
    }
}
