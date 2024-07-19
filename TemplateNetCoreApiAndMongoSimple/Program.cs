using TemplateNetCoreApiAndMongoSimple.Models;
using TemplateNetCoreApiAndMongoSimple.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<BookStoreDatabaseSettings>(  // BookStoreDatabase trong file appsetting.json được đăng ký vào Dependency Injection (DI)
    builder.Configuration.GetSection("BookStoreDatabase")); // thuộc tính trong BookStoreDatabaseSetting sẽ liên kết với thuộc tính trong BookStoreDatabase trong appsetting.json

builder.Services.AddSingleton<BooksService>(); // đăng ký BookService vào DI

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

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
