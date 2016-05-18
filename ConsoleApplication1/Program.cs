using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            int telefono;
            string numero = "n°0000";
            int libros = 0;
            int libro = 0;
            int pre, des, vdes, iv, tot;
            int mr, mc;

            Console.WriteLine("Escoger el libro");
            libros = int.Parse(Console.ReadLine());
            
            if (libros == 1)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 1000 * libro;
                des = 15;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                                  ");
                Console.Write("Cantidad    ");
                Console.Write("Precio     ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("El Señor de los anillos, Las dos torres. " + libro + "        " + pre + "        " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("El Señor de los anillos, Las dos torres. " + libro + "        " + pre + "        " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 2)
            {

                libro = int.Parse(Console.ReadLine());
                pre = 2000 * libro;
                des = 5;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Alicia en el país de la Maravillas.     " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Alicia en el país de la Maravillas.     " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");
            }
            if (libros == 3)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 3000 * libro;
                des = 10;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                        ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Cementerio de Mascotas.          " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                        ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Cementerio de Mascotas.          " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");

            }
            if (libros == 4)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 4000 * libro;
                des = 20;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                             ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Quiero aprender.              " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                    ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Quiero aprender.              " + libro + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 5)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 5000 * libro;
                des = 25;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("El poder del pensamiento Positivo.   " + libro + "           " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("El poder del pensamiento Positivo.   " + libro + "           " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 6)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 6000 * libro;
                des = 20;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Mi primer libro de matemáticas.        " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Mi primer libro de matemáticas.        " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");

            }

            if (libros == 7)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 7000 * libro;
                des = 5;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Las aventuras de Tom Sawyer.           " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Las aventuras de Tom Sawyer.           " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 8)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 8000 * libro;
                des = 15;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("El mago de Oz.                         " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("El mago de Oz.                         " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 9)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 9000 * libro;
                des = 10;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("La zona muerta.                        " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("La zona muerta.                        " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");


            }
            if (libros == 10)
            {
                libro = int.Parse(Console.ReadLine());
                pre = 10000 * libro;
                des = 25;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Viaje al centro de la tierra.         " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Libreria El Buen Lector         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                               ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Viaje al centro de la tierra.         " + libro + "         " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");
            }
            else
            {
                Console.WriteLine("");
            }     
                Console.ReadKey();
            }
     
        }
    }

