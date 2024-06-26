using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace CapaLogicaNegocio
{
    public class FacturaServiceBase : FacturaServiceBaseBase
    {
        public override bool Factura(string numeroFactura, DateTime fechaFactura, int idCliente, decimal totalFactura, System.Data.DataTable detallesFactura);
    }

    public class FacturaService : FacturaServiceBase
    {
    }
}
