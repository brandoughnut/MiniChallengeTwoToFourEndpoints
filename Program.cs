using MiniChallengeTwoToFourEndpoints.Services.AddService;
using MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService;
using MiniChallengeTwoToFourEndpoints.Services.AddService.AskingService.GreaterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddService, AddService>();
builder.Services.AddScoped<IAskingService, AskingService>();
builder.Services.AddScoped<IGreaterService, GreaterService>();

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
