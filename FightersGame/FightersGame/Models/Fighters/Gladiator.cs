using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    public class Gladiator : BaseFighter
    {
        public override string ClassName { get; } = "Гладиатор";

        public Gladiator( string name, IRace race ) : base( name, race )
        {
            ClassHealthPoints = 20;
        }
    }
}