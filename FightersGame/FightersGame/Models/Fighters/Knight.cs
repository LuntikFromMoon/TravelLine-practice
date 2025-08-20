using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    public class Knight : BaseFighter
    {
        public override string ClassName { get; } = "Рыцарь";

        protected override double ClassDamagePoints => 2.2;

        public Knight( string name, IRace race ) : base( name, race )
        {
        }
    }
}