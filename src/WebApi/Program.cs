// add a namespave for resriteoptions
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // 로컬 환경일 때는 스웨거를 활성시킨다.
    app.UseSwaggerUI();

    // add a new rewrite option instance to redirect the root path to the swagger UI
    var option = new RewriteOptions();
    option.AddRedirect("^$", "swagger"); // 루트로 들어오면 스웨거로 리디렉션한다.
    app.UseRewriter(option);

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
