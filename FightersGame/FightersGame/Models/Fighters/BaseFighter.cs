using Fighters.Models.Armors;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters
{
    public class BaseFighter : IFighter
    {
        private readonly IRace _race;
        private IArmor _armor = new NoArmor();
        private IWeapon _weapon = new Fists();
        private double ArmorPoints = 0;
        private readonly Random _random = new Random();

        protected double ClassArmorPoints = 0;
        protected double ClassDamagePoints = 0;
        protected double ClassHealthPoints = 0;

        private double _currentHealth;

        public string Name { get; private set; }
        public virtual string ClassName { get; } = "Без класса";

        protected BaseFighter( string name, IRace race )
        {
            Name = name;
            _race = race;

            _currentHealth = GetMaxHealth();
            ArmorPoints = CalculateStartArmor();
        }

        public double GetCurrentHealth() => _currentHealth;

        public double GetMaxHealth() => _race.Health + ClassHealthPoints;

        public double GetLuck() => _race.Luck + _armor.LuckPoints + _weapon.LuckPoints;

        public double CalculateDamage()
        {
            bool isCrit = CalculateCrit();
            if ( isCrit )
            {
                return ( _weapon.Damage + _race.Damage + ClassDamagePoints ) * _weapon.CritDamageModifier;
            }

            return _weapon.Damage + _race.Damage + ClassDamagePoints;
        }

        public bool CalculateCrit()
        {
            double randNum = ( double )_random.NextDouble();

            return randNum <= _weapon.CritChance;
        }

        public double CalculateStartArmor() => _armor.Armor + _race.Armor + ClassArmorPoints;

        public void timeArmorDebuff( double breakProcent )
        {
            if ( breakProcent < 1 )
            {
                ArmorPoints = CalculateStartArmor() * ( 1 - breakProcent );
            }
            else
            {
                ArmorPoints = 0;
            }
        }

        public void SetArmor( IArmor armor )
        {
            _armor = armor;
            ArmorPoints = CalculateStartArmor();
        }

        public void SetWeapon( IWeapon weapon )
        {
            _weapon = weapon;
        }

        public void TakeDamage( double damage )
        {
            double newHealth = _currentHealth - damage;
            if ( newHealth < 0 )
            {
                newHealth = 0;
            }

            _currentHealth = newHealth;
        }

        public void BeAttacked( IFighter fighter )
        {
            double realDamage = fighter.CalculateDamage() - ArmorPoints;
            if ( realDamage < 0 )
            {
                realDamage = 0;
            }

            TakeDamage( realDamage );
        }

        public string WriteInfo()
        {
            return $"Имя: {Name}, \nРаса: {_race.Name}, \nКласс: {ClassName}, \nОружие: {_weapon.Name}, \nБроня: {_armor.Name}.";
        }
    }
}