using Microsoft.EntityFrameworkCore;
using terscapasSi.Model.Context;
using terscapasSi.Model.Entities;

namespace terscapasSi.Model.Services
{
    internal class CategoriaService
    {

        //private List<Categoria> tablaCategorias = new List<Categoria>();
        private readonly AplicationDbContext _context;
        //*************************************

        public CategoriaService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(Properties.Settings.Default.ConnectionString);
            _context = new AplicationDbContext(optionsBuilder.Options);
        }

        //metodo para crear una nueva categoria
        public bool CrearCategoria(Categoria nuevaCategoria)
        {
            try
            {
                _context.Categoria.Add(nuevaCategoria); //agrega la nueva categoria
                _context.SaveChanges();
                return true; // exito
            }
            catch
            {
                return false; // en caos de error 
            }
        }
        //*************************************
        //metodo para obtener todas las categorias 
        public List<Categoria> ObtenerTodas()
        {
            return _context.Categoria.ToList(); // retorna la lista de categoias 
        }

        //metodo ob categoria por ID
        public Categoria ObtenerPorID(int id)
        {
            return _context.Categoria.Where(c => c.Id == id).FirstOrDefault();
            //busca categoria por id
        }
        //*************************************
        //metodo actualizar caterogia 
        public bool ActualizarCategoria(int id, Categoria categoriaActualizada)
        {
            try
            {
                var categoria = ObtenerPorID(id);

                if (categoria != null)
                {
                    categoria.Name = categoriaActualizada.Name;
                    categoria.Activa = categoriaActualizada.Activa;
                    _context.SaveChanges();
                    return true;
                    //actualiza con exito
                }
                return false; // no encuentra categoria 
            }
            catch
            {
                return false; //error durante 
            }

        }

        //*************************************
        //metodo opara eliminar una categoria 
        public bool EliminarCategoria(int id)
        {
            try
            {
                var categoria = ObtenerPorID(id); // bjusca actegoria 
                if (categoria != null)
                {
                    _context.Categoria.Remove(categoria); //elimina categoria
                    _context.SaveChanges();
                    return true;

                }
                return false; // cat no encontrada
            }
            catch
            {
                return false; //cat no encontrada
            }
        }

    }
}
