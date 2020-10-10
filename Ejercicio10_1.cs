using System;

namespace Cap10_12
{​​​​

    class Ejercicio10_1
    {​​​​
        public float Precio {​​​​ get; set; }​​​​

        public int Unidades {​​​​ get; set; }​​​​

        public String NombreProducto {​​​​ get; set; }​​​​

        public Tienda()
        {​​​​

            Precio = 0;
            Unidades = 0;
            NombreProducto = string.Empty;

        }​​​​

        public Tienda(float precio, int unidades, String nombreProducto)

        {​​​​

            Precio = precio;
            Unidades = unidades;
            NombreProducto = nombreProducto;

        }​​​​

    }​​​​
}​​​​