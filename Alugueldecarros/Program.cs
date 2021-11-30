using System;
using System.Globalization;

namespace Alugueldecarros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informando sobre o aluguel de carros
            Console.WriteLine("Enter the location data: ");
            Console.Write("model: ");
            string model = Console.ReadLine();
            Console.Write("Check-in (dd / MM / yyyy HH: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check-out (dd / MM / yyyy HH: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //valor da hora
            Console.Write("Enter the hourly rate: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //valor do dia
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Criando a lista
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            //Calculando o valor da fatura
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            //mandando o valor da fatura
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            Console.ReadKey();
        }
    }
}
