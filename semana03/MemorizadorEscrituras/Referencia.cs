    public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculoInicial;
    private int _versiculoFinal;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculo;
        _versiculoFinal = versiculo;
    }

    public Referencia(string livro, int capitulo, int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculoInicial;
        _versiculoFinal = versiculoFinal;
    }

    public string GetDisplayText()
    {
        if (_versiculoInicial == _versiculoFinal)
        {
            return $"{_livro} {_capitulo}:{_versiculoInicial}";
        }

        return $"{_livro} {_capitulo}:{_versiculoInicial}-{_versiculoFinal}";
    }
}