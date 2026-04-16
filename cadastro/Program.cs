var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => {
    return  new { mensagem= "API em execução"};
});

app.MapGet("/for", () => {
    for (int i = 0; i < 5; i++) {
	    Console.WriteLine(i);
    }
});

app.MapGet("/while", () => {

int i = 0;

while(i < 5) {
	Console.WriteLine(i);
	i++;
    }
});

app.MapGet("/objeto", () => {
 Funcionario f = new Funcionario();

    f.SetNome(nome);
    f.SetIdade(idade);
    f.SetCargo(cargo);
    f.SetDepartamento(departamento);

    // Adiciona no vetor
    funcionarios[totalFuncionarios] = f;
    totalFuncionarios++;

    return Results.Ok(new
    {
        nome = f.GetNome(),
        idade = f.GetIdade(),
        cargo = f.GetCargo(),
        departamento = f.GetDepartamento()
    });
});

app.Run();