


//Variables
int opcion = 0;
int cantidad = 0;
int operaciones = 0;
int entradasVendidas = 0;
int bebidasVendidas = 0;
string nombre = "";
string entrada = "";
string bebida = "";
double precioEntrada = 0;
double precioBebida = 0;
double total = 0;
double pago = 0;
double cambio = 0;
double recaudacion = 0;
double operacionMasCara = 0;
string clienteMasCaro = "";

//Menu con las distintas opciones
do
{
    Console.WriteLine("DISCOPARTY");
    Console.WriteLine("1. Comprar entradas");
    Console.WriteLine("2. Escoger bebida");
    Console.WriteLine("3. Consultar resumen");
    Console.WriteLine("0. Salir");
    Console.Write("Escoge una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    //Compra de entradas
    switch (opcion)
    {
        case 1:
            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("TIPOS DE ENTRADA");
            Console.WriteLine("1 Anticipada - 10 euros");
            Console.WriteLine("2 En el dia - 15 euros");
            Console.WriteLine("3 VIP - 25 euros");
            Console.Write("Escoge una entrada: ");
            int tipoEntrada = Convert.ToInt32(Console.ReadLine());

            if (tipoEntrada == 1)
            {
                entrada = "Anticipada";
                precioEntrada = 10;
            }
            else if (tipoEntrada == 2)
            {
                entrada = "General";
                precioEntrada = 15;
            }
            else if (tipoEntrada == 3)
            {
                entrada = "VIP";
                precioEntrada = 25;
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
                break;
            }

            Console.Write("¿Cuántas entradas quieres?: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad no válida.");
                break;
            }

            double subtotal = precioEntrada * cantidad;
            double descuento = 0;

            if (cantidad >= 5)//Descuento del 10% por 5 o mas
            {
                descuento = subtotal * 0.10;
            }

            total = subtotal - descuento;

            Console.WriteLine("RESUMEN DE COMPRA");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Entrada: " + entrada);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Subtotal: " + subtotal + " euros");
            Console.WriteLine("Descuento: " + descuento + " euros");
            Console.WriteLine("Total: " + total + " euros");

            Console.Write("Introduce el dinero para pagar: ");
            pago = Convert.ToDouble(Console.ReadLine());

            while (pago < total)
            {
                Console.WriteLine("Error.");
                Console.Write("Error");
                pago = Convert.ToDouble(Console.ReadLine());
            }

            cambio = pago - total;

            Console.WriteLine("Cambio: " + cambio + " euros");
            Console.WriteLine("¡Gracias por comprar en DISCOPARTY!");

            operaciones++;
            entradasVendidas += cantidad;
            recaudacion += total;

            if (total > operacionMasCara)
            {
                operacionMasCara = total;
                clienteMasCaro = nombre;
            }

            break;

        //Elegir la bebida y cantidad
        case 2:
            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("BEBIDAS");
            Console.WriteLine("1. Cubata - 6 euros");
            Console.WriteLine("2. Chupito - 2 euros");
            Console.WriteLine("3. Cerveza - 3 euros");
            Console.Write("Escoge un bebida: ");
            int tipoBebida = Convert.ToInt32(Console.ReadLine());

            if (tipoBebida == 1)
            {
                bebida = "Cubata";
                precioBebida = 6;
            }
            else if (tipoBebida == 2)
            {
                bebida = "Chupito";
                precioBebida = 2;
            }
            else if (tipoBebida == 3)
            {
                bebida = "Cerveza";
                precioBebida = 3;
            }
            else
            {
                Console.WriteLine("Bebida no válido.");
                break;
            }

            Console.Write("¿Cuántos quieres?: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad no válida.");
                break;
            }

            total = precioBebida * cantidad;
            //Resumen de la compra de bebidas
            Console.WriteLine("TICKET");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Bebida: " + bebida);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Total: " + total + " euros");

            Console.Write("Introduce el dinero para pagar: ");
            pago = Convert.ToDouble(Console.ReadLine());

            while (pago < total)
            {
                Console.WriteLine("Error.");
                Console.Write("Introduce el dinero de nuevo: ");
                pago = Convert.ToDouble(Console.ReadLine());
            }

            cambio = pago - total;

            Console.WriteLine("Cambio: " + cambio + " euros");
            Console.WriteLine("¡Gracias por tu compra!");

            operaciones++;
            bebidasVendidas += cantidad;
            recaudacion += total;

            if (total > operacionMasCara)
            {
                operacionMasCara = total;
                clienteMasCaro = nombre;
            }

            break;

        //Resumen de la compra en general
        case 3:
            Console.WriteLine("RESUMEN DE DISCOPARTY");
            Console.WriteLine("Operaciones realizadas: " + operaciones);
            Console.WriteLine("Entradas vendidas: " + entradasVendidas);
            Console.WriteLine("Bebidas vendidos: " + bebidasVendidas);
            Console.WriteLine("Recaudación total: " + recaudacion + " euros");

            if (operaciones > 0)
            {
                Console.WriteLine("Media por operación: " +
                    (recaudacion / operaciones) + " euros");
                Console.WriteLine("Operación más cara: " +
                    operacionMasCara + " euros");
                Console.WriteLine("Cliente: " + clienteMasCaro);
            }

            break;

        //Salir
        case 0:
            Console.WriteLine("Cerrando DISCOPARTY...");
            break;

        //Error
        default:
            Console.WriteLine("Error.");
            break;
    }

} while (opcion != 0);



