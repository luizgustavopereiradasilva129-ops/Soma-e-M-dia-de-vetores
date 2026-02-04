using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            Console.WriteLine("Quantas linhas vão ser digitadas?");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas colunas vão ser digitadas?");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];
            int soma = 0;
            double media;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                    soma += mat[i, j];
                    media = soma / (double)(M * N);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz digitada:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("A soma dos elementos é: " + soma);
            Console.WriteLine("A média dos elementos é: " + (soma / (double)(M * N)));
        }
    }
}
