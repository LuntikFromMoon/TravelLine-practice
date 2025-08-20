namespace CarFactory.Models.Transmissions
{
    internal class Mechanical : ITransmission
    {
        public int GearsAmount => 5;

        public string Name => "Механическая";
    }
}