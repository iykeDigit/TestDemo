using FinalAPIDemo;
using FinalAPIDemo.Core;
using FinalAPIDemo.Data;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

//configure logger
var logger = new LoggerConfiguration()
             .ReadFrom.Configuration(builder.Configuration)
             .Enrich.FromLogContext()
             .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

    // Add services to the container.



    builder.Services.AddControllers();
    //builder.Services.AddDbContext<AppDbContext>(options =>
    //{
    //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    //});
  //  builder.Services.AddScoped<IPlayersService, PlayersService>();

  //  builder.Services.AddScoped<IDataSeeder, DataSeeder>();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

builder.Services.Extensions(builder.Configuration);
    

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.SeedData();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();


    app.Run();



