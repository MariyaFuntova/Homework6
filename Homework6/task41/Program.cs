int [] GetUserArray (int length, int start, int end)
{
    Console.Write("Введите число М (количество вводимых чисел): ");
    length = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");        
}
int NumberLargerZero (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int [] newArray = GetUserArray(5, -10, 10);
PrintArray (newArray);
int countNumber = NumberLargerZero(newArray);
Console.WriteLine($"Количество чисел больше 0 = {countNumber}");
