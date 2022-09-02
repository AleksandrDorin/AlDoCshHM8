// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void PrintMatrix(int[,] element)
{
    for (int i = 0; i < element.GetLength(0); i++)
    {
        for (int j = 0; j < element.GetLength(1); j++)
        {
            Console.Write($"{element[i, j]} \t");
        }
        Console.WriteLine("");
    }
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
}

int[,] array = new int[4, 4];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine("");
int i = 0, j = 0, i1, j1, mini = 0, minj = 0;
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        if (array[i, j] < array[mini, minj])
        {
            mini = i;
            minj = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент матрицы: {array[mini, minj]} с индексом {mini}, {minj} ");
Console.WriteLine("Преобразованная матрица:");
int[,] array2 = new int[3, 3];
for (i = 0; i < 3; i++)
{
    if (i >= mini)
    {
        i1 = i + 1;
    }
    else
    {
        i1 = i;
    }
    for (j = 0; j < 3; j++)
    {
        if (j >= minj)
        {
            j1 = j + 1;
        }
        else
        {
            j1 = j;
        }
        array2[i, j] = array[i1, j1];
    }
}
PrintMatrix(array2);