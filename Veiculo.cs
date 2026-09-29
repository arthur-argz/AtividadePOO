namespace AtividadePOO;

public abstract class Veiculo
{
    public string Modelo { get; private set; }
    public int Ano { get; private set; }

    protected Veiculo(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
    }

    public void Ligar()
    {
        Console.WriteLine($"{Modelo} está ligado!");
    }

    public virtual void Acelerar()
    {
        Console.WriteLine($"{Modelo} está acelerando!");
    }
}