namespace CarFactory.Models.Engines
{
    internal class Diesel : IEngine
    {
        public string Name => "Дизельный";

        public int Power => 160;
    }
}