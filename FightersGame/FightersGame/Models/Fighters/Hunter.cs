using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    public class Hunter : BaseFighter
    {
        public override string ClassName { get; } = "Охотник";

        public Hunter( string name, IRace race ) : base( name, race )
        {
            ClassDamagePoints = 2;
        }
    }
}