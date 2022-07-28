using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IOrderProductDal, EfOrderProductDal>();
builder.Services.AddSingleton<IOrderDal, EfOrderDal>();
builder.Services.AddSingleton<IOrderService, OrderManager>();
builder.Services.AddSingleton<IDeliveryDal, EfDeliveryDal>();
builder.Services.AddSingleton<IDeliveryService, DeliveryManager>();
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