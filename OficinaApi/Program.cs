using Microsoft.EntityFrameworkCore;
using OficinaAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados MySQL
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 33)) // Substitua pela versão do MySQL instalada
    )
);

// Adiciona os controladores ao contêiner de serviços
builder.Services.AddControllers();

var app = builder.Build();

// Defina a URL e a porta para a aplicação
app.Urls.Add("http://localhost:5032");  

// Configuração do pipeline de requisição
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
