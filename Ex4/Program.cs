using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*04. Faça um programa que apure o resultado de uma votação para determinar o personagem animado
            favorito das pessoas. Suponha que existam cinco candidatos cujos códigos de identificação são:
            0. Perna Longa
            1. Pluto
            2. Mickey
            3. Bob Esponja
            4. Cebolinha
            O programa deverá ler 100 votos e depois apresentar como resultado:
            ● a quantidade de votos do candidato mais votado e seu código de identificação
            ● a quantidade de votos do candidato menos votado e seu nome
            ● a quantidade de votos nulos (um voto nulo é um voto cujo código de identificação é um inteiro
            diferente de 0,1,2,3,4).
            Dica: use cada posição do vetor como um contador*/

            int[] candidato = new int[100];
            string[] nomes = { "Perna Longa", "Pluto", "Mickey", "Bob Esponja", "Cebolinha" };
     
            int nulos = 0;

            for (int rep = 1; rep <= 7; rep++)
            {
                Console.WriteLine(@"Informe o número do candidato desejado:
                                    0. Perna Longa
                                    1. Pluto
                                    2. Mickey
                                    3. Bob Esponja
                                    4. Cebolinha
                                 ");
                int voto = int.Parse(Console.ReadLine());

                if (voto >= 0 && voto <= 4)
                    candidato[voto]++;
                else
                    nulos++;
            }

            int maisVotado = 0;
            int menosVotado = candidato[0];

            for (int i = 0; i < candidato.Length; i++)
            {
                if (candidato[i] > candidato[maisVotado])
                {
                    maisVotado = i;
                }
            }

            for (int i = 0; i < candidato.Length; i++)
            {
                if (candidato[i] < candidato[menosVotado])
                {
                    menosVotado = i;
                }
            }

            Console.WriteLine($"Candidato mais votado: {maisVotado} com {candidato[maisVotado]} votos;");
            Console.WriteLine($"Candidato menos votado: {nomes[menosVotado]} com {candidato[menosVotado]} votos;");
            Console.WriteLine($"Votos Nulos: {nulos};");
        }
    }
}
