using System;

namespace Escenario01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller Patrones de Diseño - Escenario 01");

            CarConfigurator carConfigurator;

            CarConstructor carConstructor = new CarConstructor();
            carConfigurator = new SuvConstructor();
            carConstructor.ConfigOptions(carConfigurator);
            Console.WriteLine("Configuración SUV:");
            carConfigurator.Auto.GetConfigOptions();
            Console.WriteLine();

            carConfigurator = new TaxiConstructor();
            carConstructor.ConfigOptions(carConfigurator);
            Console.WriteLine("Configuración Taxi:");
            carConfigurator.Auto.GetConfigOptions();
            Console.WriteLine();

            carConfigurator = new SportConstructor();
            carConstructor.ConfigOptions(carConfigurator);
            Console.WriteLine("Configuración Deportivo:");
            carConfigurator.Auto.GetConfigOptions();
            Console.WriteLine();

        }
    }
}