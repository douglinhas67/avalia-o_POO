public class Jogador
{
    private string nome;
    private int idade;
    private string posicao;

    private int numeroCamisa;

    public Jogador(string nome, int idade, string posicao, int numeroCamisa)
    {
        Nome = nome;
        Idade = idade;
        Posicao = posicao;
        NumeroCamisa = numeroCamisa;
    }

    public string Nome
    {
        get { return nome; }
        set {if }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public string Posicao
    {
        get { return posicao; }
        set { posicao = value; }
    }

    public int NumeroCamisa
    {
        get { return numeroCamisa; }
        set {  if(value > 0) 
        {
            numeroCamisa = value;
        } 
        
        else { throw new ArgumentException("O número da camisa deve ser maior que zero."); } }
    }
}