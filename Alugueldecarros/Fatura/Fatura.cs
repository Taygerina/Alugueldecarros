using System;
using System.Globalization;

namespace Alugueldecarros
{
    class Invoice
    {
        //Variaveis
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        //Variavel para o total 
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        //Imprimir pagamentos basicos, impostos e pagamento total.
        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    //Informação do modelo
        class Vehicle
        {
            public string Model { get; set; }
            public Vehicle(string model)
            {
                Model = model;
            }
        }
       //variaveis com as informações
        class CarRental
        {
            public DateTime Start { get; set; }
            public DateTime Finish { get; set; }
            public Vehicle Vehicle { get; private set; }
            public Invoice Invoice { get; set; }
            public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
            {
                Start = start;
                Finish = finish;
                Vehicle = vehicle;
                Invoice = null;
            }
        }
    }
   

