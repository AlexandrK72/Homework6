// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int[] EnterArray(int len)
{
    int[] array = new int[len];
    int i = 0;
    while (i < len)
    {
        Console.WriteLine("Введите элемент массива");
        string value = Console.ReadLine();
        array[i] = Convert.ToInt32(value);
        i++;
    }
    return array;
}

 void PrintArray(int[] arr)
 {
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
     
}

int PositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        count ++;
    }
    return count;
}

int lenght = Prompt("Ведите количество элементов массива ");
int [] arr = EnterArray(lenght);
int res = PositiveNumbers(arr);
PrintArray(arr);
Console.Write("-> ");
Console.Write(res);
