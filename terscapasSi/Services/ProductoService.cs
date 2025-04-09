using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terscapasSi.Model.Entities;

namespace terscapasSi.Services
{
    internal class ProductoService
    {
        //simula la tabla de producto de BBDD
        private List<Producto> tablaProducto = new List<Producto>();



        //metodo para agregar o crear producto
        public bool CrearProducto(Producto nuevoProducto)
        {
            try
            {
                tablaProducto.Add(nuevoProducto);//agrega producto
                return true;//devuelve true que se agrego
            }
            catch
            {
                return false; // devuelve false si hay un error
            }


        }

        //metodo para obtener all productos
        public List<Producto> ObtenerTodos()
        {
            return tablaProducto;//lista completa de productos
        }

        //buscar un producto por ID
        public Producto ObtenerPorId(int id)
        {
            return tablaProducto.Find(p => p.Id == id); // expresion lambda lamretorna el mproducto con el id buscado
        }

        //metodo para actualizar un producto existente
        public bool ActualizarProducto(int id, Producto productoActualizado)
        {
            try
            {
                var producto = ObtenerPorId(id);//buscamos por id

                if (producto != null)
                {
                    //remmplaza ls valores
                    producto.Name = productoActualizado.Name;
                    producto.CodigoBarras = productoActualizado.CodigoBarras;
                    producto.Descripcion = productoActualizado.Descripcion;
                    producto.Precio = productoActualizado.Precio;
                    producto.Categoria = productoActualizado.Categoria;
                    producto.Stock = productoActualizado.Stock;
                    return true; 
                    //true indica que de actualizo correctamente 

                }
                return false; // no se encontro 
            }
            catch
            {
                return false; // ocurrio un error
            }

        }


        // metodo para eliminar producto
        public bool EliminarProducto(int id)
        {
            try
            {
                var producto = ObtenerPorId(id); //busca por id

                if (producto != null)
                {
                    tablaProducto.Remove(producto); // elimina el producto
                    return true;

                }
                return false; // si no se encontro el producto para elimianr


            }
            catch
            {
                return false;   //error al intentar eliminar 
            }
        }
    }

        
    
}
