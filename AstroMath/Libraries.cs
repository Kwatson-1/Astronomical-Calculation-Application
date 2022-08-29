using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class Formulas
    {
        // Accepts two input parameters (Observed Wavelength and Rest Wavelength) and returns a double which represents the velocity. 
        public static double StarVelocity(double observedWavelength, double restWavelength)
        {
            double changeInWavelength = observedWavelength - restWavelength;
            return 299792458 * changeInWavelength / restWavelength;
        }
        // Accepts a single input parameter of type double (arcsecond angle) and returns a double which is a value in parsecs.
        public static double StarDistance(double arcsecondAngle)
        {
            return 1 / arcsecondAngle;
        }
        // Accepts an input paramter of type double (temperature in Celcius) and returns a double which is the temperature in degrees kelvin.
        public static double TemperatureKelvin(double temperatureCelcius)
        {
            return temperatureCelcius + 273.15;
        }
        // Accepts an single input paramter of type double (black hole mass) and returns a double which is the event horizon (Schwarzschild Radius) in meters.
        public static double EventHorizon(double blackHoleMass)
        {
            return 2 * (6.674 * Math.Pow(10, -11)) * blackHoleMass / (Math.Pow(299792458, 2));
        }
    }
}