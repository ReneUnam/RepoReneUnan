﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    internal class DProducto
    {
        //Propiedades
        private int _Id_Productos;
        private string _Nombre;
        private string _Descripcion;
        private int _IdCategoria;
        private float _PrecioVenta;
        private int _Stock;
        private DateTime _Fecha_Vencimiento;
     

        //Atributos
        public int idProductos { get => _Id_Productos; set => _Id_Productos = value; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int IdCategoria { get; set; }

        public double PrecioVenta { get; set; }

        public int Stock { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}
