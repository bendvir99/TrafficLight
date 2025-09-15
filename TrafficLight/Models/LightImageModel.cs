using static TrafficLight.Models.TrafficLightModel;

namespace TrafficLight.Models
{
    abstract class LightImageModel
    {
        protected string[] lightImages = { "crysmiley.jpg", "thinksmile.jpg", "happeysmile.jpg", "thinksmile2.jpg" };
        public abstract string GetLightImage(TrafficLightState state);
    }
}
