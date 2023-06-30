using ConversordeMonedaWEB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1.Add services to the container.



//MVC
builder.Services.AddControllersWithViews();


//Agregar Servicio Repositorio
builder.Services.AddScoped<IConversorRepositorio, ConversorRepositorio>(); //Inyeccion de dependencia

//Agregar Repositorio Conversor Repositorio BaseDatos
//builder.Services.AddScoped<IConversorRepositorio, ConversorRepositorioBaseDatos >();

//Base de Datos
builder.Services.AddDbContext<ContextoDatos>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ConversorConexion"]);
}
);


var app = builder.Build();

// 2.Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
