using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Models;

namespace TrafficLight.ModelsLogic
{
    class LightImage : LightImageModel
    {
        public override string GetLightImage(TrafficLightModel.TrafficLightState state)
        {
            return lightImages[(int)state];
        }
    }
}
