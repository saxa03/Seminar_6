// Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

Console.Clear();
Console.Write("Введите элементы через пробел:");
int[] elements = StringConIntArr(Console.ReadLine());
Console.WriteLine($"Количество элементов > 0 –> {CountPositiveelements(elements)}");
Console.WriteLine();

int[] StringConIntArr(string s)//функция перевода строки в массив чисел
{
    string[] nums = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i<res.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}


int CountPositiveelements(int[] arr)//функция счета положительных чисел с использованием foreach
{
    int count = 0;
    foreach (var i in arr)
    {
        if(i>0) count++;
    }
    return count;
}