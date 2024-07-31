using Microsoft.OpenApi.Models;
using EasyMESEdgeIntegration.Infrastructure.Commons;
using AutoMapper;
using EasyMESEdgeIntegration.WebApi.Quality;
using EasyMESEdgeIntegration.Infrastructure.Quality;
using EasyMESEdgeIntegration.Application.Quality.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kata", Version = "v1" });
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateCollectionFormAnswerAutomatedHandler).Assembly));
builder.Services.AddEasyMESEdge(builder.Configuration);
var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<CreateCollectionFormAnswerAutomatedProfile>();
    cfg.AddProfile<CreateCollectionFormAnswerAutomatedEasyMESProfile>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
