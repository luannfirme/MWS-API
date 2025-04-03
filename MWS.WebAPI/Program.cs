using MWS.Persistence;
using MWS.Application.Services;
using MWS.WebAPI.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigurePresentationApp();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
