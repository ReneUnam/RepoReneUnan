﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public struct Roles
    {
        public const int Administrador = 1;
        public const int Vendedor = 2;

        static public string rolConverter(int rol)
        {
            string rolToString;
            if (rol == Administrador) rolToString = "Administrador";
            else rolToString = "Vendedor";

            return rolToString;
        }
    }

}
