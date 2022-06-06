using NPS_PROJECT_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<RelacionalClienteContext>(x => x.UseSqlServer(
             builder.Configuration.GetConnectionString("NPS_Connection")
         //,x => x.MigrationsAssembly("NPS_Connection")
         ));

builder.Services.AddDbContext<PesquisaGeralContext>(x => x.UseSqlServer(
             builder.Configuration.GetConnectionString("NPS_Connection")
         //,x => x.MigrationsAssembly("NPS_Connection")
         ));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
