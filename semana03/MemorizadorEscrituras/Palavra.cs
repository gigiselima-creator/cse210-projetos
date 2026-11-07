public class Palavra
{
    private string _texto;
    private bool _oculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _oculta = false;
    }

    public void Ocultar()
    {
        _oculta = true;
    }

    public bool EstaOculta()
    {
        return _oculta;
    }

    public string GetDisplayText()
    {
        if (_oculta)
        {
            return new string('_', _texto.Length);
        }

        return _texto;
    }
}