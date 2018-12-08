namespace VehicleFactory
{
    internal class Gasoline : ICarEngine
    {
        public string GetEngineInfo()
        {
            return "this brand uses gasoline engine";
        }
    }
}