using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[5];

            for (int i = 0; i < notas.Length; i++)
            {
                double nota;
                do
                {
                    Console.Write($"Digite a nota {i + 1} (0 a 100): ");
                    nota = double.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("Valor inválido! Digite uma nota entre 0 e 100.");
                        nota = double.Parse(Console.ReadLine());
                    }

                } while (nota < 0 || nota > 100);

                notas[i] = nota;
            }

            int opcao;

            do
            {
                Console.WriteLine($@"Opções
                                1. Mostrar menor nota
                                2. Mostrar maior nota
                                3. Pesquisar nota
                                4. Mostrar média das notas e quantidade de notas acima da média
                                5. Sair ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        double menorNota = notas[0];

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] < menorNota)
                                menorNota = notas[i];
                        }
                        Console.WriteLine($"Menor nota: {menorNota}");
                        break;

                    case 2:
                        double maiorNota = notas[0];

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] > maiorNota)
                                maiorNota = notas[i];
                        }
                        Console.WriteLine($"Maior nota: {maiorNota}");
                        break;

                    case 3:
                        Console.Write("Digite a nota que deseja pesquisar: ");
                        double pesquisar = double.Parse(Console.ReadLine());

                        bool encontrou = false;

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (pesquisar == notas[i])
                            {
                                Console.WriteLine($"Nota {pesquisar} encontrada na posição {i + 1}");
                                encontrou = true;
                                break;
                            }
                            if (!encontrou)
                                Console.WriteLine($"Nota {pesquisar} não encontrada");
                        }
                        break;
                }
            } while (opcao != 5);
        }
    }
}

