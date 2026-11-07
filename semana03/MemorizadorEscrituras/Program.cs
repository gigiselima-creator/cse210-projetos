using System;

class Program
{
    static void Main(string[] args)
    {
        // Criatividade: o programa possui uma pequena biblioteca
        // de escrituras e seleciona uma delas aleatoriamente.
        // Também oculta três palavras por rodada, evitando
        // selecionar palavras que já foram ocultadas.

        Random random = new Random();

        Escritura[] biblioteca = new Escritura[]
        {
            new Escritura(
                new Referencia("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito."
            ),

            new Escritura(
                new Referencia("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
            )
        };

        Escritura escritura = biblioteca[random.Next(biblioteca.Length)];

        while (!escritura.TodasPalavrasOcultas())
        {
            Console.Clear();

            Console.WriteLine(escritura.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Pressione Enter para ocultar palavras ou digite 'sair'.");

            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }

        Console.Clear();

        Console.WriteLine(escritura.GetDisplayText());

        Console.WriteLine();

        if (escritura.TodasPalavrasOcultas())
        {
            Console.WriteLine("Parabéns! Você ocultou todas as palavras.");
        }
        else
        {
            Console.WriteLine("Programa encerrado.");
        }
    }
}