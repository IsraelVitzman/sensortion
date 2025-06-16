using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class SensorFectory
    {
        Dictionary<string, Func<string>> sensorActions;
        Sensor sensor;

        public  SensorFectory()
        {
            sensorActions = new Dictionary<string, Func<string>>()
            {
              { "Audio",sensor. Audio },
              { "Thermal",sensor. Thermal},
              { "Pulse",sensor. Pulse },
              { "Motion", sensor.Motion },
              { "Magnetic", sensor.Magnetic},
              { "Signal", sensor.Signal },
              { "Light", sensor.Light }
            };


        }
        public Dictionary<string, Func<string>> getSensorFectory()
        {
            return sensorActions;
        }
    }
}
