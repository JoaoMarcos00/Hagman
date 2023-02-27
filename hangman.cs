using System;

namespace JogoDaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "banana"; // palavra a ser adivinhada
            string palavraAdivinhada = "";
            int maxTentativas = 6;
            int tentativas = 0;
            char letra;

            // Inicializar a palavra a ser adivinhada com traços
            for (int i = 0; i < palavra.Length; i++)
            {
                palavraAdivinhada += "_";
            }

            while (palavraAdivinhada != palavra && tentativas < maxTentativas)
            {
                Console.WriteLine("A palavra é: " + palavraAdivinhada);
                Console.WriteLine("Digite uma letra: ");
                letra = char.Parse(Console.ReadLine());

                bool acertou = false;

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        palavraAdivinhada = palavraAdivinhada.Remove(i, 1).Insert(i, letra.ToString());
                        acertou = true;
                    }
                }

                if (!acertou)
                {
                    tentativas++;
                    Console.WriteLine($"Você errou! Restam {maxTentativas - tentativas} tentativas.");
                }
            }

            if (palavraAdivinhada == palavra)
            {
                Console.WriteLine("Parabéns! Você acertou a palavra!");
            }
            else
            {
                Console.WriteLine($"Você perdeu! A palavra era {palavra}.");
            }

            Console.ReadKey();
        }
    }
}
