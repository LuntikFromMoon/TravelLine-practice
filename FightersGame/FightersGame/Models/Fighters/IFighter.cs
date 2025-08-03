using Fighters.Models.Armors;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters
{
    public interface IFighter
    {
        string Name { get; }
        string ClassName { get; }

        public double GetCurrentHealth();
        public double GetMaxHealth();
        public double GetLuck();
        public double CalculateDamage();
        public double CalculateStartArmor();
        public void timeArmorDebuff( double breakProcent );
        public void SetArmor( IArmor armor );
        public void SetWeapon( IWeapon weapon );
        public void TakeDamage( double damage );
        public void BeAttacked( IFighter fighter );
        public string WriteInfo();
    }
}