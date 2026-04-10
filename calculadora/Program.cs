// Cria um objeto responsável por configurar a aplicação ASP.NET
var builder = WebApplication.CreateBuilder(args);

// Define o endereço e a porta em que a aplicação irá escutar requisições HTTP
builder.WebHost.UseUrls("http://localhost:8000");

// Constrói a aplicação web a partir das configurações definidas no builder
var app = builder.Build();

app.MapGet("/", () => {
    return new {mensagem= "API em execução ..."};
});

app.MapGet("/calcula/soma/{a}/{b}", (double a, double b) => {
   return new {mensagem = "Soma = ", resultado = a + b };
});
app.MapGet("/calcula/subtracao/{a}/{b}", (double a, double b) => {
   return new {mensagem = "Subetração = ", resultado = a - b };
});
app.MapGet("/calcula/multiplicacao/{a}/{b}", (double a, double b) => {
   return new {mensagem = "Multiplicacão = ", resultado = a * b };
});
app.MapGet("/calcula/divisao/{a}/{b}", (double a, double b) => {
   return new {mensagem = "Divisão = ", resultado = a / b };
});
// Inicia o servidor web é iniciado e passa a aguardar requisições HTTP dos clientes
app.Run();