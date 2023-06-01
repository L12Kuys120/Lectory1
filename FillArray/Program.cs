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



