// Генерация массива из 10-случайных элементов целых чисел
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
