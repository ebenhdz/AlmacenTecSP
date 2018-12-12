using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class PrestamoDataContext
    {
        public IEnumerable<Prestamo> GetAllPrestamo()
        {
            var items = this.Prestamos.Select(item => item).OrderBy(item => item.idPrestamo);

            return items;
        }
    }
}