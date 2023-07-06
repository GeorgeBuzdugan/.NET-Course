using System;

namespace lab3ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni
            avand lungimile n m, respectiv m,n. Lungimile celor doua dimensiuni ale
            matricilor, m si n, vor fi citite de la tastaura. */

            static int GetMatrixDimension()
            {
                Console.WriteLine("Introduceti numarul de randuri si coloane a matricelor: \n");
                return int.Parse(Console.ReadLine());
            }

            static int[,] GetMatrix(int dimension)
            {
                int[,] matrix = new int[dimension, dimension];

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        Console.WriteLine($"\nIntroduceti elementul de cu indexul [{i + 1}, {j + 1}]\n");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                return matrix;
            }

            static int[,] MultiplyMatrix(int dimension, int[,] matrix1, int[,] matrix2)
            {
                int[,] result = new int[dimension, dimension];

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < dimension; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }

                return result;
            }

            static void PrintMatrix(int dimension, int[,] matrix)
            {
                Console.WriteLine();
                for (int i = 0; i < dimension; i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < dimension; j++)
                    {
                        Console.Write(string.Format("{0} ", matrix[i, j]));
                    }
                    Console.Write(" |");
                    Console.WriteLine();
                }
            }

            int dimension = GetMatrixDimension();

            int[,] matrix1 = GetMatrix(dimension);
            int[,] matrix2 = GetMatrix(dimension);
            PrintMatrix(dimension, MultiplyMatrix(dimension, matrix1, matrix2));
        }
    }
}
