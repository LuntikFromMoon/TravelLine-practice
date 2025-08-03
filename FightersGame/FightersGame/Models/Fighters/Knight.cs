using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    public class Knight : BaseFighter
    {
        public override string ClassName { get; } = "Рыцарь";

        public Knight( string name, IRace race ) : base( name, race )
        {
            ClassArmorPoints = 2.2;
        }
    }
}