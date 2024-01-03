/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/* Ввод элементов через пробел
Console.Write("Введите элементы (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
*/
Console.Write("Введите число -> размер массива: ");
int massive = Convert.ToInt32(Console.ReadLine());
int[]arr = new int[massive];
for (int i = 0; i < massive; i++)
{
    Console.Clear();
    Console.Write("Введите целое число массива (положительное или отрицательное):  ");
    int number = Convert.ToInt32(Console.ReadLine());
    arr[i] = number;
    
}
Console.Clear();
Console.WriteLine($"Массив: [ {String.Join("; ",arr)} ]");
int positive = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
       positive += 1;
    }
}
Console.WriteLine($"Количество элементов в массиве больше нуля :  {positive} ");

