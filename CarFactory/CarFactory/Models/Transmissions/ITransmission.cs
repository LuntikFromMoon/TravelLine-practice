namespace CarFactory.Models.Transmissions
{
    internal interface ITransmission
    {
        int GearsAmount { get; }
        string Name { get; }
    }
}