using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Semina.data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmployeeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnectionString")));

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

//namespace ConnectMysq
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MySqlConnection conn = new MySqlConnection("Server= ASUT02\\CEPHEID; Database=vendor; Trusted_Connection= true; Pwd=;");
//        }
//    }
//}

