using System;
using System.Collections.Generic;

class Bus
{
    public string Nombre;
    public int TotalAsientos;
    public int Pasajeros;
    public int PrecioPasaje;

    public int Ventas()
    {
        return Pasajeros * PrecioPasaje;
    }

    public int AsientosDisponibles()
    {
        return TotalAsientos - Pasajeros;
    }

    public void MostrarReporte()
    {
        Console.WriteLine($"{Nombre} {Pasajeros} Pasajeros Ventas {Ventas()} quedan {AsientosDisponibles()} asientos disponibles");
    }
}

class Program
{
    static void Main()
    {
        List<Bus> listaBuses = new List<Bus>();

        Console.WriteLine("=== Sistema de Cobro de Pasajes ===");

        bool continuar = true;

        while (continuar)
        {
            Bus nuevoBus = new Bus();

            Console.Write("\nNombre del bus: ");
            nuevoBus.Nombre = Console.ReadLine();

            Console.Write("Total de asientos: ");
            nuevoBus.TotalAsientos = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de pasajeros: ");
            nuevoBus.Pasajeros = int.Parse(Console.ReadLine());

            Console.Write("Precio del pasaje: ");
            nuevoBus.PrecioPasaje = int.Parse(Console.ReadLine());

            listaBuses.Add(nuevoBus);

            Console.Write("\n¿Deseas agregar otro bus? (s/n): ");
            string opcion = Console.ReadLine().ToLower();
            if (opcion != "s") continuar = false;
        }

        Console.WriteLine("\n=== RESUMEN FINAL ===");
        foreach (Bus bus in listaBuses)
        {
            bus.MostrarReporte();
        }
    }
}
