using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_GENERATION
{
   

        class Cliente
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Carnet_identidad { get; set; }
        }
        class Suplemento
        {
            
            public string Nombre { get; set; }
            public string Cantidad { get; set; }
            public int Precio { get; set; }
        }

        

        class Inventario
        {
            
            public Suplemento Suplemento { get; set; }

        }
         class Pedido
        {
            public Cliente Cliente { get; set; }
            public  List<Suplemento> Suplementos{ get; set; }
            public Calcular()
            {
                double total = 0;
                foreach (var suplemento in Suplementos)
                {
                    total += suplemento.Precio;
                }
                return total;
            }
            
        }

        class Factura
        {
             public Suplemento Suplemento { get; set; }
            public int NumFactura { get; set; }
            public DateTime FechaEmision { get; set; }
            public double Total { get; set; }
            
        }

    internal class Program
    {

        static void Main(string[] args)
        {
            Suplemento Suplemento1 = new Suplemento
            {
                Nombre = "Proteina wey gold standar",
                Cantidad ="500 gr",
                Precio = 600 
            
                
            };
            Suplemento Suplemento2 = new Suplemento
            {
                Nombre = " creatina",
                Cantidad = "350 gr",
                Precio = 459


            };
            Suplemento Suplemento3 = new Suplemento
            {
                Nombre = " Aminoacidos",
                Cantidad = "300 gr",
                Precio = 300


            };
            Suplemento Suplemento4 = new Suplemento
            {
                Nombre = "quemador de grasa",
                Cantidad = "500 gr",
                Precio = 500


            };
            Factura factura = new Factura
            {
                NumFactura = 10,
                FechaEmision = DateTime.Now,
                Suplemento= Suplemento1,
                
            };
            factura.Total = Suplemento1.calcular();

        }
    }
}
