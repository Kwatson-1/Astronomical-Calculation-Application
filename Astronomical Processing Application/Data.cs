using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Processing_Application
{
    [Serializable]
    class Data : IComparable<Data>
    {
        private String starVelocity;
        private String eventHorizon;
        private String temperatureKelvin;
        private String starDistance;

        public Data()
        {

        }

        public Data(string starVelocity, string eventHorizon, string temperatureKelvin, string starDistance)
        {
            this.starVelocity = starVelocity;
            this.eventHorizon = eventHorizon;
            this.temperatureKelvin = temperatureKelvin;
            this.starDistance = starDistance;
        }

        public string GetStarVelocity()
        {
            return starVelocity;
        }
        public string GetEventHorizon()
        {
            return eventHorizon;
        }
        public string GetTemperatureKelvin()
        {
            return temperatureKelvin;
        }
        public string GetStarDistance()
        {
            return starDistance;
        }
        public void SetStarVelocity(string starVelocity)
        {
            this.starVelocity = starVelocity;
        }
        public void SetEventHorizon(string eventHorizon)
        {
            this.eventHorizon = eventHorizon;
        }
        public void SetTemperatureKelvin(string temperatureKelvin)
        {
            this.temperatureKelvin = temperatureKelvin;
        }
        public void SetStarDistance(string starDistance)
        {
            this.starDistance = starDistance;
        }

        public int CompareTo(Data other)
        {
            return starVelocity.CompareTo(other.starVelocity);
        }



        //public static String ToString(Information info)
        //{
        //    String output = String.Format("Name: {0}\nCategory: {1}\nStructure: {2}\nDefinition: {3}", info.GetName(), info.GetCategory(), info.GetStructure(), info.GetDefinition());
        //    return output;
        //}
    }
}
