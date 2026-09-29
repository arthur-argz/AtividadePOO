using AtividadePOO;

class Program
{
    static void Main(string[] args)
    {
        Veiculo[] veiculos =
        {
            new Carro("Fusca", 1978),
            new Moto("Honda CG", 2020),
            new Caminhao("Scania R450", 2018)
        };

        foreach (Veiculo veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
            Console.WriteLine();
        }
    }
}