public class Partida
{
    private string timeCasa;
    private string timeVisitante;  

    private int golsTimeCasa;
    private int golsTimeVisitante;

    public string TimeCasa
    {
        get { return timeCasa; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome do time da casa não pode ser vazio!");
            }
            else
            {
                timeCasa = value;
            }
        }
    }  

    public string TimeVisitante
    {
        get { return timeVisitante; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome do time visitante não pode ser vazio!");
            }
            else
            {
                timeVisitante = value;
            }
        }
    }

    public int GolsTimeCasa
    {
        get { return golsTimeCasa; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O número de gols do time da casa não pode ser negativo!");
            }
            else
            {
                golsTimeCasa = value;
            }
        }
    }

    public int GolsTimeVisitante
    {
        get { return golsTimeVisitante; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O número de gols do time visitante não pode ser negativo!");
            }
            else
            {
                golsTimeVisitante = value;
            }
        }
    }

    public Partida(string timeCasa, string timeVisitante, int golsTimeCasa, int golsTimeVisitante)
    {
        TimeCasa = timeCasa;
        TimeVisitante = timeVisitante;
        GolsTimeCasa = golsTimeCasa;
        GolsTimeVisitante = golsTimeVisitante;
    }

    public override string ToString()
    {
        return $"Partida: {TimeCasa} vs {TimeVisitante} - {GolsTimeCasa} x {GolsTimeVisitante}";
    }
}