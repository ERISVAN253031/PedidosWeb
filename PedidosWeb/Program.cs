using Microsoft.EntityFrameworkCore;
using PedidosWeb.Models;


var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços ao contêiner.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<MeuDbContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=XPTO;User Id=postgres;Password=root;"));

var app = builder.Build();

// Configure o pipeline de solicitação HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // O valor HSTS padrão é de 30 dias. Você pode querer alterar isso para cenários de produção, consulte https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();