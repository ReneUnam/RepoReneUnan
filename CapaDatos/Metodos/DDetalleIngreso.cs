using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    internal class DDetalleIngreso
    {
        //propiedades
        private int _Id_DetalleIngreso;
        private int _Cantidad;
        private int _PrecioUnitario;
        private float _SubTotal;
        private int _Id_Producto;
        private int _Id_Ingreso;
        private int _PrecioVenta;
        private int _stock;

        //Atributos
        public int Id_DetalleIngreso { get => _Id_DetalleIngreso; set=> _Id_DetalleIngreso = value; }
        public int Cantidad { get => _Cantidad; set=> _Cantidad = value;}
        public int PrecioUnitario { get => _PrecioUnitario; set=> _PrecioUnitario = value;}
        public float SubTotal { get=> _SubTotal; set=> _SubTotal = value;}
        public int Id_Productos { get => _Id_Producto; set => _Id_Producto = value;}
        public int Id_Ingreso { get=> _Id_Ingreso; set=> _Id_Ingreso = value;}
        public int PrecioVenta { get=> _PrecioVenta; set=> _PrecioVenta = value; }
        public int Stock { get => _stock; set=> _stock = value; }

        
    }
}
