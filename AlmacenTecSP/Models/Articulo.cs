using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class ArticuloDataContext
    {
        public IEnumerable<Articulo> GetAllArticulos()
        {
            var items = this.Articulos.Select(item => item).OrderBy(item => item.nombre);

            return items;
        }
    }
}