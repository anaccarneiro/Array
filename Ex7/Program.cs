using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*07. Leia dois vetores de inteiros x e y, cada um com 5 elementos (assuma que para um mesmo vetor, o
            usuário não informará elementos repetidos). Calcule e mostre o resultado das seguintes operações:
            ● Soma entre x e y: soma de cada elemento de x com o elemento da mesma posição em y.
            ● Produto entre x e y: multiplicação de cada elemento de x com o elemento da mesma posição em y.
            ● Diferença entre x e y: todos os elementos de x que não existam em y.
            ● Interseção entre x e y: apenas os elementos que aparecem nos dois vetores.
            ● União entre x e y: todos os elementos de x e de y, mas sem elementos repetidos.*/

            int contadorX = 0, contadorY = 0;


            int[] X = new int[5];
            int[] Y = new int[5];

            while (contadorX < 5)
            {
                Console.WriteLine($"Informe o {contadorX + 1}º número do vetor X:");
                int numX = int.Parse(Console.ReadLine());

                bool repetidoX = false;

                for (int i = 0; i < contadorX; i++)
                {
                    if (X[i] == numX)
                    {
                        repetidoX = true;
                        break;
                    }
                }
                if (repetidoX)
                {
                    Console.WriteLine("Número repetido! Tente outro.");
                }
                else
                {
                    X[contadorX] = numX;
                    contadorX++;
                }
            }

            while (contadorY < 5)
            {
                Console.WriteLine($"Informe o {contadorY + 1}º número do vetor Y:");
                int numY = int.Parse(Console.ReadLine());

                bool repetidoY = false;

                for (int j = 0; j < contadorY; j++)
                {
                    if (Y[j] == numY)
                    {
                        repetidoY = true;
                        break;
                    }
                }
                if (repetidoY)
                {
                    Console.WriteLine("Número repetido! Tente outro.");
                }
                else
                {
                    Y[contadorY] = numY;
                    contadorY++;
                }
            }
            //Soma
            //Produto
            //Diferença entre x e y: todos os elementos de x que não existam em y
            Console.WriteLine("Diferença");

            for (int i = 0; i < X.Length; i++)
            {
                bool encontradoDiferenca = false;

                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        encontradoDiferenca = true;
                        break;
                    }
                }
                if (!encontradoDiferenca)
                {
                    Console.Write(X[i] + " , ");
                }
            }

            //Interseção entre x e y: apenas os elementos que aparecem nos dois vetores.
            Console.WriteLine("\n\nInterseção");

            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        Console.Write(X[i] + " , ");
                    }
                }
            }

            //União entre x e y: todos os elementos de x e de y, mas sem elementos repetidos.
            Console.WriteLine("\n\nUnião");

            bool encontrado = false;

            for (int i = 0; i < X.Length; i++)
            {
                Console.Write(X[i] + " , ");
            }

            for (int j = 0; j < Y.Length; j++)
            {
                encontrado = false;

                for (int i = 0; i < X.Length; i++)
                {
                    if (Y[j] == X[i])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.Write(Y[j] + " , ");
                }
            }
        }
    }
}
