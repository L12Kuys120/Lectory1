//Ввод аргумента
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;

}
int length = Prompt("Введите число");
//----------------------------------------------------------------

// Распечатывание массива
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        Console.Write(collection[index]);
        index++;
    }

}
//----------------------------------------------------------------
// Генерация массива случайных элементов целых чисел от 1 до 9
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    
}
//----------------------------------------------------------------

// Сортировка массива с выбором минимального эл-та
int[ ] arr = {1, 2, 3, 4, 5, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];         
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

SelectionSort(arr);
PrintArray(arr);
//-----------------------------------------------------------------

// Нахождение эл-та массива
int FindElem(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;

    while(index < length)
    {
        if(collection[index] == find) 
        {
            position = index;
            break;
        }
    }
}
