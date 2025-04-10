using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;

namespace terscapasSi.Model.Context
{
    //AQUI DEFINIMOS EL CONTEXT (ESTRUCUTRA) DE LA BASE DE DATOS
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(
            DbContextOptions<AplicationDbContext> options): base(options)
        { 

        }
        //AQUI INDICAMOS QUE LAS SIGUIENTES CLASES (ENTITIES)
        //CORRESPONDEN A TABLAS DE LA BBDD
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<User> User { get; set; }

    }
}
