using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Interfaces;
using YamanerECommerce.Persistence.Context;
using YamanerECommerce.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<YamanerECommerceContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));

builder.Services.AddScoped<GetCartQueryHandler>();
builder.Services.AddScoped<GetCartByIdQueryHandler>();
builder.Services.AddScoped<CreateCartCommandHandler>();
builder.Services.AddScoped<UpdateCartCommandHandler>();
builder.Services.AddScoped<RemoveCartCommandHandler>();

builder.Services.AddControllers();
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
