using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;

namespace terscapasSi.Services
{
    internal class CategoriaService
    {

        private List<Categoria> tablaCategorias = new List<Categoria>();

        //*************************************
        //metodo para crear una nueva categoria
        public bool CrearCategoria(Categoria nuevaCategoria)
        {
            try
            {
                tablaCategorias.Add(nuevaCategoria); //agrega la nueva categoria
                return true; // exito

            }catch
            {
                return false; // en caos de error 
            }
        }
        //*************************************
        //metodo para obtener todas las categorias 
        public List<Categoria> ObtenerTodas()
        {
            return tablaCategorias; // retorna la lista de categoias 
        }

        //metodo ob categoria por ID
        public Categoria ObtenerPorID(int id)
        {
            return tablaCategorias.Find(c => c.Id == id); 
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
                    return true;
                    //actualiza con exito

                }
                return false; // no encuentra categoria 


            } catch
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
                if(categoria != null)
                {
                    tablaCategorias.Remove(categoria); //elimina categoria
                    return true; 

                }
                return false; // cat no encontrada

            } catch
            {
                return false; //cat no encontrada
            }
        }




    }
}
