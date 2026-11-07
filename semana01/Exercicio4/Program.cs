using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        
        // Perceba que também poderiamos usar um laço do-while aqui
        int numeroUsuario = -1;
        while (numeroUsuario != 0)
        {
            Console.Write("Digite um número (0 para sair): ");
            
            string respostaUsuario = Console.ReadLine();
            numeroUsuario = int.Parse(respostaUsuario);
            
            // Somente acidione o numero à lista se ele não for 0
            if (numeroUsuario != 0)
            {
                numeros.Add(numeroUsuario);
            }
        }

        // Part 1: Calcule a soma
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma é: {soma}");

        // Parte 2: Calcular a média
        // Perceba que primeiro fazemos uma conversão da variável soma para float. Caso contrário,
        // como tanto soma quanto Count (quantidade) são inteiros, o computador fará a divisão inteira
        // e eu não obterei um valor decimal (mesmo que o resultado seja armazenado em uma variável float).
        
        // Ao transformar uma das variáveis em float primeiro, o computador sabe que precisa
        // fazer a divisão com ponto flutuante, e assim obtemos o valor decimal que esperamos.
        
        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        // Parte 3: Encontre o maior
        // Há diversas maneiras de fazer isso, como por exemplo ordenar a lista
        
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                // se esse número for maior que 'maior', nós encontramos o novo valor para 'maior'!
                maior = numero;
            }
        }

        Console.WriteLine($"O maior valor é: {maior}");
    }
}