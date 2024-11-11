//Utilizando Matrizes:
//Problema "matriz_geral"
//Ler uma matriz quadrada de ordem N (máximo = 10), contendo números reais. Em seguida, fazer as
//seguintes ações:
//a) calcular e imprimir a soma de todos os elementos positivos da matriz.
//b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
//c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
//d) imprimir os elementos da diagonal principal da matriz.
//e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada. 

using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace MatrizGeralMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, linhaEscolhida, colunaEscolhida;
            double somaPositivos = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        somaPositivos += mat[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"SOMA DOS POSITIVOS: {somaPositivos.ToString("F1", CI)}");

            Console.WriteLine();
            Console.Write("Escolha uma linha: ");
            linhaEscolhida = int.Parse(Console.ReadLine(), CI);

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[linhaEscolhida, i].ToString("F1", CI) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escolha uma coluna: ");
            colunaEscolhida = int.Parse(Console.ReadLine(), CI);

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, colunaEscolhida].ToString("F1", CI) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CI) + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        mat[i, j] = Math.Pow(mat[i, j], 2); ;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}