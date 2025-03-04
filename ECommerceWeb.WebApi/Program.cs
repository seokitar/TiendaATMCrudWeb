using Azure;
using EcommerceWeb.Entidades;
using EcommerceWeb.Repositorios.Implementaciones;
using EcommerceWeb.Repositorios.Interfaces;
using ECommerceWeb.DataAccess.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EcommerceDbContext>(options =>
{
    //Se estable la conexión al EF CORE a traves del archivo de configuracion
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));
}
);
//Agregamos los repositorios
builder.Services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
builder.Services.AddTransient<IProductoRepositorio, ProductoRepositorio>();
builder.Services.AddTransient<IVentaRepositorio, VentaRepositorio>();
builder.Services.AddTransient<IClienteRepositorio, ClienteRepositorio>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/clientes", (IClienteRepositorio repositorio) =>
{
    var clientes = repositorio.Listar();
    return Results.Ok(clientes);
});

app.MapGet("api/clientes/{id}", (IClienteRepositorio repositorio,int id) =>
{
    var clientes = repositorio.buscarPorId(id);
    return Results.Ok(clientes);
});

app.MapGet("api/categorias", (ICategoriaRepositorio repositorio) =>
    {
        var categorias = repositorio.Listar();
        return Results.Ok(categorias);
    });


app.MapGet("api/productos", (IProductoRepositorio repositorio) =>
    {
        var productos = repositorio.Listar();
        return Results.Ok(productos);
    });

app.MapGet("api/productos/{id:int}", (IProductoRepositorio repositorio,int id) =>
{
        var productos = repositorio.MostrarProductoCategoria(id);
        return Results.Ok(productos);  
});

//Muestra venta detallada con venta_detalle
app.MapGet("api/ventas/{id:int}", (IVentaRepositorio repositorio, int id) =>
    {
        var ventas = repositorio.MostrarVenta(id);
        return Results.Ok(ventas);

    });

//Muestra venta detallada con venta_detalle pero se indica los datos a imprimir
app.MapGet("api/ventas2/{id:int}", (IVentaRepositorio repositorio, int id) =>
{
    var ventas = repositorio.MostrarVenta(id);


    return Results.Ok(new
    {

        Id = ventas.Id,
        NombreCliente = ventas.Cliente.Nombre,
        NumeroProductos = ventas.Detalles.Count,

    });

});
//Por corregir
app.MapPut("api/productos/{id}", (IProductoRepositorio repositorio,int id) =>
{
    var productos = new Producto()
    {
       Nombre = "Samsung A80",
       Precio = 100.50f
    };


    repositorio.Actualizar(id,productos);
   

});

app.Run();
