using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class SalidaArticuloDataContext
    {
        public IEnumerable<SalidaArticulo> GetAlSalidaArt()
        {
            var items = this.SalidaArticulos.Select(item => item).OrderBy(item => item.idSaArt);

            return items;
        }
    }
}