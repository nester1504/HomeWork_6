bool check = false;
int number = 0;
int sizeArray = 0;
int count = 0;

int ReadNumber()
{
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            check = true;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}

Console.WriteLine("Введите длину массива");
sizeArray = ReadNumber();

int[] array = new int[sizeArray];


int ReadCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < sizeArray; i++)
    {

        Console.WriteLine($"Введите число номер {i + 1} ");
        array[i] = ReadNumber();
        if (array[i] > 0)
        {
            count++;
        }

    }
    return count;
}

count = ReadCount(array);

Console.WriteLine(String.Join("; ", array));

Console.WriteLine($"Положительных чисел = {count}");