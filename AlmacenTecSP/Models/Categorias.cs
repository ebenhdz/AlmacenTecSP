using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class CategoriasDataContext
    {
        public IEnumerable<Categoria> GetAllCateg()
        {
            var items = this.Categorias.Select(item => item).OrderBy(item => item.nombre);

            return items;
        }
    }
}