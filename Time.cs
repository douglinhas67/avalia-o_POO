public class Time
{
    private string nome;
    private string tecnico;
    private int  anoFundacao;
    private int quantidadeTitulos;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome do time não pode ser vazio!");
            }
            else
            {
                nome = value;
            }
        }
    }

    public string Tecnico
    {
        get { return tecnico; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome do técnico não pode ser vazio!");
            }
            else
            {
                tecnico = value;
            }
        }
    }

    public int AnoFundacao
    {
        get { return anoFundacao; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ano de fundação inválido!");
            }
            else
            {
                anoFundacao = value;
            }
        }
    }

    public int quantidadeTitulos
    {
        get { return quantidadeTitulos; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Quantidade de títulos inválida!");
            }
            else
            {
                quantidadeTitulos = value;
            }
        }
    }

    public time(string nome, string tecnico, int anoFundacao, int quantidadeTitulos)
    {
        Nome = nome;
        Tecnico = tecnico;
        AnoFundacao = anoFundacao;
        QuantidadeTitulos = quantidadeTitulos;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Técnico: {Tecnico}, Ano de Fundação: {AnoFundacao}, Quantidade de Títulos: {QuantidadeTitulos}";
    }
}