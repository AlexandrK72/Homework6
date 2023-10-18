// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

double[] IntersectionOfStraightLines(double numb1, double numk1, double numb2, double numk2)
{
    double[] array = new double[2];
    array[0] = (numb2 - numb1) / (numk1 - numk2);
    array[1] = numk1 * array[0] + numb1;
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("( ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(" )");
}

int b1 = Prompt("Введите переменную b1 = ");
int k1 = Prompt("Введите переменную k1 = ");
int b2 = Prompt("Введите переменную b2 = ");
int k2 = Prompt("Введите переменную k2 = ");
if (k1 == k2)
{
    Console.WriteLine("Линии не пересекаются"); return;
}
double[] arr = IntersectionOfStraightLines(b1, k1, b2, k2);
Console.Write($" b1 =  {b1}, k1 =  {k1}, b2 = {b2}, k2 = {k2}");
Console.Write(" -> ");
PrintArray(arr);