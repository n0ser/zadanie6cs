using System.Reflection.Metadata.Ecma335;

Console.Clear();
void PrintArr(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
int[] GenerateArr(int m)
{
    int[] arrNum = new int[m];
    for (int i = 0; i < arrNum.Length; i++)
    {
        arrNum[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrNum;
}
int CountNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result += array[i];
    }
    return result;
}
Console.WriteLine("Введите количество элементов массива: ");
int ReadM(string m)
{
    int n;
    while (true)
        { 
        if (int.TryParse(Console.ReadLine(), out n))
        {
            return n;
        }
        else
        {
            Console.WriteLine("Это не число, попробуйте еще раз");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
int m = ReadM(Console.ReadLine());
Console.WriteLine("Введите по очереди элементы массива: ");
int[] array = GenerateArr(m);
PrintArr(array);
int res = CountNum(array);
Console.WriteLine($"Сумма чисел больше нуля равна {res}");