using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavrasTexto = texto.Split(' ');

        foreach (string palavra in palavrasTexto)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        Random random = new Random();

        List<int> indicesDisponiveis = new List<int>();

        for (int i = 0; i < _palavras.Count; i++)
        {
            if (!_palavras[i].EstaOculta())
            {
                indicesDisponiveis.Add(i);
            }
        }

        int quantidadeOcultar = Math.Min(
            quantidade,
            indicesDisponiveis.Count
        );

        for (int i = 0; i < quantidadeOcultar; i++)
        {
            int indiceAleatorio = random.Next(indicesDisponiveis.Count);

            int indicePalavra = indicesDisponiveis[indiceAleatorio];

            _palavras[indicePalavra].Ocultar();

            indicesDisponiveis.RemoveAt(indiceAleatorio);
        }
    }

    public bool TodasPalavrasOcultas()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }

    public string GetDisplayText()
    {
        string texto = _referencia.GetDisplayText() + " ";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.GetDisplayText() + " ";
        }

        return texto.Trim();
    }
}