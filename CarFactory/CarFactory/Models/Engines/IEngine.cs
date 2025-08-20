namespace CarFactory.Models.Engines
{
    internal interface IEngine
    {
        string Name { get; }

        int Power { get; }
    }
}