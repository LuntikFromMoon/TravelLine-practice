namespace CarFactory.Models.Engines
{
    internal class Petrol : IEngine
    {
        public string Name => "Бензиновый";

        public int Power => 300;
    }
}