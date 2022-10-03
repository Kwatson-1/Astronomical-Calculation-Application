using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroServer
{
    internal class AstroContract : IAstroContract
    {
        public double StarVelocity(double observedWaveLength, double restWaveLength)
        {
            return AstroMath.Formulas.StarVelocity(observedWaveLength, restWaveLength);
        }

        public double StarDistance(double arcsecondAngle)
        {
            return AstroMath.Formulas.StarDistance(arcsecondAngle);
        }

        public double TemperatureKelvin(double temperatureCelcius)
        {
            return AstroMath.Formulas.TemperatureKelvin(temperatureCelcius);
        }

        public double EventHorizon(double blackHoleMass)
        {
            return AstroMath.Formulas.EventHorizon(blackHoleMass);
        }
    }
}
