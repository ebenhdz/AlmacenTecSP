using System.Collections.Generic;
using System.Linq;

namespace AlmacenTecSP.Models
{
    partial class ConsumiblesDataContext
    {
        public IEnumerable<Consumible> GetAllConsumible()
        {
            var items = this.Consumibles.Select(item => item).OrderBy(item => item.idConsu);

            return items;
        }
    }
}