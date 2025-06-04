using LibraryManagementApp.Api.Repositories;
using LibraryManagementApp.Api.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IUserRepository, UserJsonRepository>();
builder.Services.AddScoped<IBookRepository, BookJsonRepository>();
builder.Services.AddScoped<IBookLoanRepository, BookLoanJsonRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
