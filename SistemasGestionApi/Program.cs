using SistemaGestionBussiness;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




var cultureInfo = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

AppContext.SetSwitch("System.Globalization.Invariant", false);  // Intenta mantener esta línea.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<ProductoBussiness>();
//builder.Services.AddScoped<UsuarioBussiness>();

builder.Services.ConfigureBussinessLayer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
