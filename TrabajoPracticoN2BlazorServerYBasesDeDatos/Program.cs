using Microsoft.EntityFrameworkCore;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Components;
using TrabajoPracticoN2BlazorServerYBasesDeDatos.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configuración de Entity Framework Core para SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro de  servicios
builder.Services.AddScoped<TrabajoPracticoN2BlazorServerYBasesDeDatos.Services.ClienteService>();
builder.Services.AddScoped<TrabajoPracticoN2BlazorServerYBasesDeDatos.Services.ServicioService>();
builder.Services.AddScoped<TrabajoPracticoN2BlazorServerYBasesDeDatos.Services.TurnoService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();