using Microsoft.EntityFrameworkCore;
using Assignment.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Kết nối SQL Server
builder.Services.AddDbContext<MinecraftDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ⚠️ Railway không cần HTTPS dev cert, nên có thể bỏ dòng này
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

// ✅ Lắng nghe trên tất cả địa chỉ, cổng 5000
app.Run("http://0.0.0.0:5000");