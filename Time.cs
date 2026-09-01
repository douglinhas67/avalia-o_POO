public class Time
{
    private string nome;
    private string tecnico;
    private int anoFundacao;
    private int quantidadeTitulos;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do time não pode ser vazio!");

            nome = value;
        }
    }

    public string Tecnico
    {
        get { return tecnico; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do técnico não pode ser vazio!");

            tecnico = value;
        }
    }

    public int AnoFundacao
    {
        get { return anoFundacao; }
        set
        {
            if (value < 1800) 
                throw new ArgumentException("Ano de fundação inválido!");

            anoFundacao = value;
        }
    }

    public int QuantidadeTitulos
    {
        get { return quantidadeTitulos; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantidade de títulos não pode ser negativa!");

            quantidadeTitulos = value;
        }
    }

    public Time(string nome, string tecnico, int anoFundacao, int quantidadeTitulos)
    {
        Nome = nome;
        Tecnico = tecnico;
        AnoFundacao = anoFundacao;
        QuantidadeTitulos = quantidadeTitulos;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Técnico: {Tecnico}, Ano de Fundação: {AnoFundacao}, Títulos: {QuantidadeTitulos}";
    }
}