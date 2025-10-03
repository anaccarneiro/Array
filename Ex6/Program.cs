using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vetA = new int[10];
            int[] vetB = new int[10];
            char[] vetC = new char[10];
            double[] vetD = new double[10];

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º número do vetor A:");
                vetA[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < vetB.Length; j++)
            {
                Console.WriteLine($"Informe o {j + 1}º número do vetor B:");
                vetB[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < vetC.Length; k++)
            {
                Console.WriteLine($"Informe a {k + 1}º operação (+, -, *, /) do vetor C:");
                vetC[k] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                for (int j = 0; j < vetB.Length; j++)
                {

                    switch (vetC[i])
                    {
                        case '+':
                            vetD[i] = vetA[i] + vetB[i];
                            break;

                        case '-':
                            vetD[i] = vetA[i] - vetB[i];
                            break;

                        case '*':
                            vetD[i] = vetA[i] * vetB[i];
                            break;

                        case '/':
                            vetD[i] = (double)vetA[i] / vetB[i];
                            break;
                    }
                }
            }

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($@"{vetA[i]} {vetC[i]} {vetB[i]} = {vetD[i]}");
            }
        }
    }
}
