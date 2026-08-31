class Program
{
    static void Main(string[] args)
    {
        Jogador j1 = new Jogador("Thomas", 15, "meio campista", 10);
        Jogador j2 = new Jogador("Gabriel Onofre", 15, "Atacante", 11);

        j1.Posicao = "meia esquerda";
        j2.NumeroCamisa = 11;

        Console.WriteLine("=== JOGADORES ===");
        Console.WriteLine(j1);
        Console.WriteLine(j2);

        Time t1 = new Time("2º MD", "Breno", 5);
        Time t2 = new Time("1º DS", "Vicente", 15);

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
