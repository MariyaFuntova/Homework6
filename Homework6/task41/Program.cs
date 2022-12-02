Console.Write("Введите число M: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
int numbersLargerZero(int[] array)
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

int NumbersLargerZero = numbersLargerZero(array);
Console.WriteLine($"Количество чисел больше 0 = {NumbersLargerZero}");
