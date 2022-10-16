// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] matrix = SpiralFillingMatrix(4);
PrintArray(matrix);


int[,] SpiralFillingMatrix(int size)
{
    int[,] matrix = new int[size, size];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            matrix[k, m] = -1;
        }
    }
    int right = 1;
    int left = 0;
    int up = 0;
    int down = 0;
    int i = 0;
    int j = 0;
    int number = 0;
    int breakControl = 0;
    while (true)
    {
        breakControl = 0;
        if (right == 1)
        {
            if (j < size - 1 && matrix[i, j + 1] == -1)
            {
                matrix[i, j] = number;
                number++;
                j++;
            }
            else
            {
                right = 0;
                down = 1;
                breakControl++;
            }
        }
        if (down == 1)
        {
            if (i < size - 1 && matrix[i + 1, j] == -1)
            {
                matrix[i, j] = number;
                number++;
                i++;
            }
            else
            {
                down = 0;
                left = 1;
                breakControl++;
            }
        }
        if (left == 1)
        {
            if (i >= 1 && matrix[i - 1, j] == -1)
            {
                matrix[i, j] = number;
                number++;
                i--;
            }
            else
            {
                left = 0;
                up = 1;
                breakControl++;
            }
        }
        if (up == 1)
        {
            if (j >= 1 && matrix[i, j - 1] == -1)
            {
                matrix[i, j] = number;
                number++;
                j--;
            }
            else
            {
                up = 0;
                right = 1;
                breakControl++;
            }
        }
        if (breakControl == 4)
        {
            matrix[i, j] = number;
            break;
        }
    }
    return matrix;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine("");
    }
}