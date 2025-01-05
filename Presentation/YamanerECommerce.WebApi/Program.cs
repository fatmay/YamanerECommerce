using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.OrderHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.UserHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.ProductQueries;
using YamanerECommerce.Application.Interfaces;
using YamanerECommerce.Persistence.Context;
using YamanerECommerce.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<YamanerECommerceContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));

builder.Services.AddScoped<GetCartItemQueryHandler>();
builder.Services.AddScoped<GetCartByIdQueryHandler>();
builder.Services.AddScoped<CreateCartCommandHandler>();
builder.Services.AddScoped<UpdateCartItemCommandHandler>();
builder.Services.AddScoped<RemoveCartItemCommandHandler>();

builder.Services.AddScoped<GetOrderByIdQueryHandler>();
builder.Services.AddScoped<GetOrderQueryHandler>();
builder.Services.AddScoped<CreateOrderCommandHandler>();
builder.Services.AddScoped<UpdateOrderCommandHandler>();
builder.Services.AddScoped<RemoveOrderCommandHandler>();

builder.Services.AddScoped<GetOrderItemQueryHandler>();
builder.Services.AddScoped<GetOrderItemByIdQueryHandler>();
builder.Services.AddScoped<CreateOrderItemCommandHandler>();
builder.Services.AddScoped<UpdateOrderItemCommandHandeler>();
builder.Services.AddScoped<RemoveOrderItemCommandHandler>();

builder.Services.AddScoped<GetCartQueryHandler>();
builder.Services.AddScoped<GetCartByIdQueryHandler>();
builder.Services.AddScoped<CreateCartCommandHandler>();
builder.Services.AddScoped<UpdateCartCommandHandler>();
builder.Services.AddScoped<RemoveCartCommandHandler>();

builder.Services.AddScoped<GetUserQueryHandler>();
builder.Services.AddScoped<GetUserByIdQueryHandler>();
builder.Services.AddScoped<CreateUserCommandHandler>();
builder.Services.AddScoped<UpdateUserCommandHandler>();
builder.Services.AddScoped<RemoveUserCommandHandler>();

builder.Services.AddScoped<GetProductByIdQueryHandler>();
builder.Services.AddScoped <GetProductQueryHandler>();
builder.Services.AddScoped<UpdateProductCommandHandler>();
builder.Services.AddScoped <RemoveProductCommandHandler>();
builder.Services.AddScoped <CreateProductCommandHandler>();

//Stock
builder.Services.AddScoped<GetStockByIdQueryHandler>();
builder.Services.AddScoped<GetStockQueryHandler>();
builder.Services.AddScoped<CreateStockCommandHandler>();
builder.Services.AddScoped<UpdateStockCommandHandler>();
builder.Services.AddScoped<RemoveStockCommandHandler>();

//Features
builder.Services.AddAplicationService(builder.Configuration);




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
