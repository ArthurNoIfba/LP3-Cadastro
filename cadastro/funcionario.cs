public class Funcionario
{
    private string? nome;
    private int idade;
    private string? cargo;

    public string? GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetIdade(int idade)
    {
        this.idade = idade;
    }

    public string? GetCargo()
    {
        return cargo;
    }

    public void SetCargo(string cargo)
    {
        this.cargo = cargo;
    }
}