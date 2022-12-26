/* Задача 48: Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] GetMartix(int rows, int columns)
{
    int[,] arrMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrMatrix[i, j] = i + j;
        }
    }
    return arrMatrix;
}
void PrintMATRIX(int[,] arrMatrix)
{
    for (int i = 0; i < arrMatrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < arrMatrix.GetLength(1); j++)
        {
            Console.Write($"{arrMatrix[i, j]} ");
            
        }Console.WriteLine();
        
    }

}


int[,] matrix = GetMartix(3, 4);
PrintMATRIX(matrix);
