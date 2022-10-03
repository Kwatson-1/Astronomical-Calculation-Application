using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Astronomical_Processing_Application
{
    [ServiceContract]
    public interface IAstroContract
    {
        // Accepts two input parameters (Observed Wavelength and Rest Wavelength) and returns a double which represents the velocity. 
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);
        [OperationContract]
        // Accepts a single input parameter of type double (arcsecond angle) and returns a double which is a value in parsecs.
        double StarDistance(double arcsecondAngle);
        [OperationContract]
        // Accepts an input paramter of type double (temperature in Celcius) and returns a double which is the temperature in degrees kelvin.
        double TemperatureKelvin(double temperatureCelcius);
        [OperationContract]
        // Accepts an single input paramter of type double (black hole mass) and returns a double which is the event horizon (Schwarzschild Radius) in meters.
        double EventHorizon(double blackHoleMass);
    }
}
