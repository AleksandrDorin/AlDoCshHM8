// Найти произведение двух матриц

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
void ProductOfMatrices(int[,] firstmatrix, int[,] secondmatrix, int[,] prodmatrix)
{
    for (int i = 0; i < prodmatrix.GetLength(0); i++)
        for (int j = 0; j < prodmatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstmatrix.GetLength(0); k++)
            {
                sum += firstmatrix[i, k] * secondmatrix[k, j];
            }
            prodmatrix[i, j] = sum;
        }
}

int[,] firstarray = new int[4, 4];
int[,] secondarray = new int[4, 4];
int[,] prodmatrix = new int[4, 4];
FillMatrix(firstarray);
FillMatrix(secondarray);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstarray);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondarray);
ProductOfMatrices(firstarray, secondarray, prodmatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintMatrix(prodmatrix);
