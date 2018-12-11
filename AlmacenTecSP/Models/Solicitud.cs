using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class SolicitudDataContext
    {
        public IEnumerable<Solicitud> GetAllCustomers()
        {
            var items = this.Solicituds.Select(item => item).OrderBy(item => item.idSolicitud);

            return items;
        }
    }
}