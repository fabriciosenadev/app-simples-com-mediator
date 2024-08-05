using mediatorPlayground.Commands.AddCustomer;
using mediatorPlayground.Commands.AddCustomerWithoutMediatr;
using mediatorPlayground.Models;
using mediatorPlayground.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddMediatR(config => 
    config.RegisterServicesFromAssemblyContaining<AddCustomerWithoutMediatrCommand>());

builder.Services.AddTransient<IPipelineBehavior<AddCustomerCommand, Result<Guid>>, ValidateCustomerBehavior>();

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
