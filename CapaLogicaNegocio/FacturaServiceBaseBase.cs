using System;

namespace CapaLogicaNegocio
{
    public abstract class FacturaServiceBaseBase
    {
        public static abstract bool NFactura(string numeroFactura, DateTime fechaFactura, int idCliente, decimal totalFactura, System.Data.DataTable detallesFactura);
    }
}