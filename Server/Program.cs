using Server;
using Server.Clients;

var builder = WebApplication.CreateBuilder(args);
var config = new AppConfiguration(builder.Configuration["ApiUsername"]!, builder.Configuration["ApiPassword"]!);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<AppConfiguration>(config);
Console.WriteLine(config);
builder.Services.AddSingleton<IRailClient, RealTimeTrainsClient>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(opt => {
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
