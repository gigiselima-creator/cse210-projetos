using System;

public class Entrada
{
    private string _data;
    private string _pergunta;
    private string _resposta;
    private string _humor;

    public Entrada(string data, string pergunta, string resposta, string humor)
    {
        _data = data;
        _pergunta = pergunta;
        _resposta = resposta;
        _humor = humor;
    }

    public string GetData()
    {
        return _data;
    }

    public string GetPergunta()
    {
        return _pergunta;
    }

    public string GetResposta()
    {
        return _resposta;
    }

    public string GetHumor()
    {
        return _humor;
    }

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_resposta}");
        Console.WriteLine($"Humor: {_humor}");
        Console.WriteLine("--------------------------------");
    }
    public Entrada()
{
    _data = "";
    _pergunta = "";
    _resposta = "";
    _humor = "";
}
public string Data
{
    get => _data;
    set => _data = value;
}

public string Pergunta
{
    get => _pergunta;
    set => _pergunta = value;
}

public string Resposta
{
    get => _resposta;
    set => _resposta = value;
}

public string Humor
{
    get => _humor;
    set => _humor = value;
}

}