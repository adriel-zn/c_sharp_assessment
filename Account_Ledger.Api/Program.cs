using Account_Ledger.Data;
using Account_Ledger.Infrastruture.Repository;
using Account_Ledger.Infrastruture.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
SetupCustomServices(ref builder);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(builder =>
    builder.WithOrigins("http://localhost:8080")
    .WithOrigins("https://localhost:7269")
           .WithMethods("POST", "GET", "OPTIONS", "PATCH", "DELETE")
           .AllowAnyHeader());

app.MapControllers();

app.Run();


void SetupCustomServices(ref WebApplicationBuilder? builder)
{
    //db contexts
    var config = builder.Configuration.GetConnectionString("LedgerAccountDatabase");
    builder.Services.AddScoped<DbContext, DatabaseContext>();
    builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(config));
    builder.Services.AddScoped<IDbConnection>(db => new SqlConnection(config));

    //repositories
    builder.Services.AddScoped<IAccountsService, AccountsRepository>();

}

