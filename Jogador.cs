public class Jogador
{
    private string nome;
    private int idade;
    private string posicao;
    private int numeroCamisa;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome não pode ser vazio!");
            }
            else
            {
                nome = value;
            }
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Idade inválida!");
            }
            else
            {
                idade = value;
            }
        }
    }

    public string Posicao
    {
        get { return posicao; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("A posição não pode ser vazia!");
            }
            else
            {
                posicao = value;
            }
        }
    }

    public int NumeroCamisa
    {
        get { return numeroCamisa; }
        set
        {
            if (value < 1 || value > 99)
            {
                Console.WriteLine("Número da camisa deve ser entre 1 e 99!");
            }
            else
            {
                numeroCamisa = value;
            }
        }
    }

    public Jogador(string nome, int idade, string posicao, int numeroCamisa)
    {
        Nome = nome;
        Idade = idade;
        Posicao = posicao;
        NumeroCamisa = numeroCamisa;
    }

/// serve para exibir um objeto
    public override string ToString()
    {
        return $"Jogador: {Nome} | Idade: {Idade} | Posição: {Posicao} | Camisa: {NumeroCamisa}";
    }

    public void IsVelho()
    {
        if (Idade >= 30)
        {
            Console.WriteLine($"{Nome} é considerado um jogador velho.");
        }
        else
        {
            Console.WriteLine($"{Nome} não é considerado um jogador velho.");
        }
    }

}