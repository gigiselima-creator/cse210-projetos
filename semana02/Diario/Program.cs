using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();

        // EXTRA: O programa registra o humor junto com cada entrada.
        // Isso ajuda o usuário a acompanhar suas emoções ao longo do tempo.
        // Também utilizamos JSON para salvar e carregar o diário,
        // permitindo preservar respostas com vírgulas e outros caracteres.

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n===== MEU DIÁRIO =====");
            Console.WriteLine("1. Escrever uma nova entrada");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar o diário");
            Console.WriteLine("4. Carregar o diário");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    diario.AdicionarEntrada();
                    break;

                case "2":
                    diario.ExibirDiario();
                    break;

                case "3":
                    diario.SalvarDiario();
                    break;

                case "4":
                    diario.CarregarDiario();
                    break;

                case "5":
                    continuar = false;
                    Console.WriteLine("Obrigado por usar o Meu Diário!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}