namespace VehicleFactory
{
    internal class Led : ICarLight
    {
        public string GetCarLightInfo()
        {
            return "This brand uses led headlight";
        }
    }
}