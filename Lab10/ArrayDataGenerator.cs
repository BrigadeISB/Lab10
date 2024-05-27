using System;

public static class ArrayDataGenerator
{
    public static int[] GenerateArray(int size, ArrayType type)
    {
        var rand = new Random(42);
        var array = new int[size];

        switch (type)
        {
            case ArrayType.Random:
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next();
                }
                break;
                //Повна випадковість
            case ArrayType.PartiallySorted:
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next();
                }
                // Часткове сортування половини масиву
                Array.Sort(array, 0, size / 2);
                break;
            case ArrayType.ManyDuplicates:
                //Створюється масив з дублікатами
                int uniqueCount = size / 10;
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(uniqueCount);
                }
                break;
        }

        return array;
    }
}
