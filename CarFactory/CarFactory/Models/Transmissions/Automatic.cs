namespace CarFactory.Models.Transmissions
{
    internal class Automatic : ITransmission
    {
        public int GearsAmount => 7;

        public string Name => "Автоматическая";
    }
}