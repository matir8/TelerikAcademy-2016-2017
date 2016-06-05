using System;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            char fill = char.Parse(Console.ReadLine());
            int[,] matrix = new int[rows , cols];
            int[] numbers = new int[rows * cols];
            for (int i = 1; i <= rows * cols; i++)
            {
                numbers[i - 1] = i;
            }

            switch (fill)
            {
                case 'a':
                    FillA(matrix,numbers,rows);
                    PrintMatrix(matrix);
                    break;
                case 'b':
                    FillB(matrix, numbers, rows);
                    PrintMatrix(matrix);
                    break;
                case 'c':
                    FillC(matrix, numbers, rows);
                    PrintMatrix(matrix);
                    break;
                case 'd':
                    FillD(matrix, numbers, rows);
                    PrintMatrix(matrix);
                    break;
            }
        }

        public static void FillA(int[,] matrix, int[] numbers, int rows)
        {
            int cols = rows;
            int currentIndex = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = numbers[currentIndex];
                    currentIndex++;
                }
            }
        }

        public static void FillB(int[,] matrix, int[] numbers, int rows)
        {
            int cols = rows;
            int currentIndex = 0;

            for (int i = 0; i < cols; i++)
            {
                if (i%2 == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j, i] = numbers[currentIndex];
                        currentIndex++;
                    }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        matrix[j, i] = numbers[currentIndex];
                        currentIndex++;
                    }
                }
            }
        }

        public static void FillC(int[,] matrix, int[] numbers, int rows)
        {
            int currentIndex = 0;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(0) - row; col++)
                {
                    matrix[row + col, col] = numbers[currentIndex];
                    currentIndex++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - row; col++)
                {
                    matrix[col - 1, col + row] = numbers[currentIndex];
                    currentIndex++;
                }
            }
        }

        //TODO

        public static void FillD(int[,] matrix, int[] numbers, int rows)
        {
            int value = 1;;
            bool canGo = true;
            string directionRight = "right";
            string directionLeft = "left";
            string directionUp = "up";
            string directionDown = "down";
            string direction = directionDown;
            int row = 0;
            int col = 0;
            while (true)
            {
                matrix[row, col] = value;
                value++;
                if (direction == directionDown)
                {
                    if ((row + 1) < rows && matrix[row + 1, col] == 0)
                    {
                        row++;
                    }
                    else if ((col + 1) < rows && matrix[row, col + 1] == 0)
                    {
                        direction = directionRight;
                        col++;
                    }
                    else
                    {
                        canGo = false;
                    }
                }
                else if (direction == directionRight)
                {
                    if ((col + 1) < rows && matrix[row, col + 1] == 0)
                    {
                        col++;
                    }
                    else if ((row - 1) >= 0 && matrix[row - 1, col] == 0)
                    {
                        direction = directionUp;
                        row--;
                    }
                    else
                    {
                        canGo = false;
                    }
                }
                else if (direction == directionUp)
                {
                    if ((row - 1) >= 0 && matrix[row - 1, col] == 0)
                    {
                        row--;
                    }
                    else if ((col - 1) >= 0 && matrix[row, col - 1] == 0)
                    {
                        direction = directionLeft;
                        col--;
                    }
                    else
                    {
                        canGo = false;
                    }
                }
                else
                {
                    if ((col - 1) >= 0 && matrix[row, col - 1] == 0)
                    {
                        col--;
                    }
                    else if ((row + 1) < rows && matrix[row + 1, col] == 0)
                    {
                        direction = directionDown;
                        row++;
                    }
                    else
                    {
                        canGo = false;
                    }
                }

                if (!canGo)
                {
                    break;
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col + 1 != matrix.GetLength(0))
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
