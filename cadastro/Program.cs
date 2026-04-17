using cadastro.Models;

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
    
    Funcionario funcionario = new Funcionario();

    funcionario.Nome = "Arthur";

    Console.WriteLine("Nome: " + funcionario.Nome);

    return Results.Ok(new {
       nome = funcionario.Nome
    });
});

app.Run();