using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class EntregablesDataContext
    {
        public IEnumerable<Entregable> GetAllCustomers()
        {
            var items = this.Entregables.Select(item => item).OrderBy(item => item.idEntrg);

            return items;
        }
    }
}