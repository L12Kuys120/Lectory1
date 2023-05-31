// Генерация массива из 10-случайных элементов целых чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    
}



