using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    public class Hunter : BaseFighter
    {
        public override string ClassName { get; } = "Охотник";

        protected override double ClassDamagePoints => 2;
        public Hunter( string name, IRace race ) : base( name, race )
        {
        }
    }
}