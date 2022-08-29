using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
namespace AstroTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to calculate star velocity");
                Console.WriteLine("Enter 2 to calculate star distance");
                Console.WriteLine("Enter 3 to calculate temperature in kelvin");
                Console.WriteLine("Enter 4 to calculate event horizon distance");
                int selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter observed wavelength: ");
                        double observedWavelength = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter rest wavelength: ");
                        double restWaveLength = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Star velocity is: " + AstroMath.Formulas.StarVelocity(observedWavelength, restWaveLength));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter arcsecond angle");
                        double arcsecondAngle = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Star distance in parsecs is: " + AstroMath.Formulas.StarDistance(arcsecondAngle));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter temperature in celcius");
                        double temperatureCelcius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Temperature in kelvin is: " + AstroMath.Formulas.TemperatureKelvin(temperatureCelcius));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the black hole mass: ");
                        double blackHoleMass = Double.Parse(Console.ReadLine());
                        Console.WriteLine("The event horizon in meters is: " + AstroMath.Formulas.EventHorizon(blackHoleMass));
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}