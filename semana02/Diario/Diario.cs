using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Diario
{
    private List<Entrada> _entradas = new List<Entrada>();

    private List<string> _perguntas = new List<string>
    {
        "Qual foi a melhor parte do meu dia?",
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "O que aprendi de novo hoje?",
        "Qual desafio consegui superar?",
        "O que gostaria de melhorar amanhã?"
    };

    private Random _random = new Random();

    public void AdicionarEntrada()
    {
        string pergunta = _perguntas[_random.Next(_perguntas.Count)];

        Console.WriteLine($"\nPergunta do dia: {pergunta}");
        Console.Write("Sua resposta: ");
        string resposta = Console.ReadLine() ?? "";

        Console.WriteLine("\nComo você está se sentindo?");
        Console.WriteLine("1 - Feliz");
        Console.WriteLine("2 - Tranquilo(a)");
        Console.WriteLine("3 - Grato(a)");
        Console.WriteLine("4 - Cansado(a)");
        Console.WriteLine("5 - Preocupado(a)");
        Console.Write("Escolha: ");

        string opcaoHumor = Console.ReadLine() ?? "";

        string humor = opcaoHumor switch
        {
            "1" => "Feliz",
            "2" => "Tranquilo(a)",
            "3" => "Grato(a)",
            "4" => "Cansado(a)",
            "5" => "Preocupado(a)",
            _ => "Não informado"
        };

        string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        Entrada entrada = new Entrada(data, pergunta, resposta, humor);

        _entradas.Add(entrada);

        Console.WriteLine("\nEntrada adicionada com sucesso!");
    }

    public void ExibirDiario()
    {
        if (_entradas.Count == 0)
        {
            Console.WriteLine("\nSeu diário está vazio.");
            return;
        }

        Console.WriteLine("\n===== MEU DIÁRIO =====");

        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void SalvarDiario()
    {
        Console.Write("Digite o nome do arquivo para salvar (ex: diario.json): ");
        string nomeArquivo = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nomeArquivo))
        {
            Console.WriteLine("Nome de arquivo inválido.");
            return;
        }

        try
        {
            string json = JsonSerializer.Serialize(
                _entradas,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(nomeArquivo, json);

            Console.WriteLine("Diário salvo com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar: {ex.Message}");
        }
    }

    public void CarregarDiario()
    {
        Console.Write("Digite o nome do arquivo para carregar: ");
        string nomeArquivo = Console.ReadLine() ?? "";

        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        try
        {
            string json = File.ReadAllText(nomeArquivo);

            List<Entrada>? entradasCarregadas =
                JsonSerializer.Deserialize<List<Entrada>>(json);

            if (entradasCarregadas != null)
            {
                _entradas = entradasCarregadas;
                Console.WriteLine("Diário carregado com sucesso!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar: {ex.Message}");
        }
    }
}