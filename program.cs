class Program
{
    static void Main(string[] args)
    {
        Jogador j1 = new Jogador("Messi", 39, "Atacante", 10);
        Jogador j2 = new Jogador("Neymar Jr", 34, "Atacante", 10);

        j1.Posicao = "Ponta Direito";
        j2.NumeroCamisa = 11;

        Console.WriteLine("=== JOGADORES ===");
        Console.WriteLine(j1);
        Console.WriteLine(j2);

        Time t1 = new Time("Barcelona", "Hansi Flick", 5);
        Time t2 = new Time("Real Madrid", "Carlo Ancelotti", 15);

        t1.QuantidadeTitulos = 6; 

        Console.WriteLine("=== TIMES ===");
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine();

        Partida p1 = new Partida("Barcelona", "Real Madrid", 3, 2);

        Partida p2 = new Partida("1º DS", "2ºMD", 6, 1);

        p2.GolsMandante = 2;

        Console.WriteLine("=== PARTIDAS ===");
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
