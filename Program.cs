using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Console.WriteLine(".....Bienvenido al sistema de pagos.....");

        System.Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        System.Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();

        System.Console.Write("Ingrese su DNI:");
        int dni = int.Parse(Console.ReadLine());

        System.Console.Write("Ingrese su correo: ");
        string correo = Console.ReadLine();

        Cliente cliente = new Cliente(nombre, apellido, dni, correo);

        Console.Write("Ingrese el monto a pagar: ");
        int monto = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Seleccione metodo de pago: ");
        System.Console.WriteLine("1. Efectivo/Transferencia");
        System.Console.WriteLine("2. Tarjeta");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                System.Console.Write("Ingrese con cuanto va a pagar:");
                int pago = int.Parse(Console.ReadLine());

                int idEfectivo = rnd.Next(9999, 99999);

                Efectivo efectivo = new Efectivo(monto, cliente, idEfectivo, pago);
                
                efectivo.MostrarInfo();
                cliente.InformacionUsuario();
                break;

            case 2:
                System.Console.WriteLine("Seleccione: ");
                System.Console.WriteLine("1. Debito");
                System.Console.WriteLine("2. Credito");

                int opcionTarjeta = int.Parse(Console.ReadLine());

                switch (opcionTarjeta)
                {
                    case 1:
                        int idDebito = rnd.Next(9999, 99999);

                        Tarjeta debito = new Tarjeta(monto, cliente, idDebito, "Debito", 10);

                        debito.MostrarInfo();
                        cliente.InformacionUsuario();
                        break;

                    case 2:
                        int idCredito = rnd.Next(9999, 99999);

                        Tarjeta credito = new Tarjeta(monto, cliente, idCredito, "Credito", 20);
                        
                        credito.MostrarInfo();
                        cliente.InformacionUsuario();
                        break;
                }
                break;

        }
    }
}
