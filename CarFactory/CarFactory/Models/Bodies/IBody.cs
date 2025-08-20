namespace CarFactory.Models.Bodies
{
    internal interface IBody
    {
        string Name { get; }

        double CrossSectionalArea { get; }

        double DragCoefficient { get; }
    }
}