using Microsoft.EntityFrameworkCore;
using Practica05Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Practica05Productos.Data
{
    public class ProductosDbContext : DbContext
    {
        public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base (options)
        {

        }

        //Define una tabla en una base de datos
        public DbSet<Producto> Productos { get; set; }
    }
}
