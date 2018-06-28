using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring my variables for conversion.
            double temp = 0;
            double centTemp = 0;
            double farenTemp = 0;
            double kelvinTemp = 0;

            // Say hello and get a figure from the user.
            Console.WriteLine("Hello and welcome to the temperature converter!");
            Console.WriteLine("Enter a number to be converted: ");
            string getInput = Console.ReadLine();
            temp = double.Parse(getInput);

            // Dispay the figures.
            Console.WriteLine("You entered: {0}", temp);
            Console.WriteLine("Now converting the temperatures...");

            // Convert the figures.
            centTemp = temp;
            
            // Display the figure in Celcius.
            Console.WriteLine("The figure in Celcius: {0}", centTemp);
            
            // Display the figure in Farenheight.
            farenTemp = (1.8 * temp) + 32;
            Console.WriteLine("The figure in Farenheight: {0}", farenTemp);

            // Display the figure in Kelvin.
            kelvinTemp = temp + 273.15;
            Console.WriteLine("The figure in Kelvin: {0}", kelvinTemp);

            // Say goodye.
            Console.WriteLine("Thank you, please try again sometime!");
            Console.ReadKey();
        }
    }
}
