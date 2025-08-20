using Fighters.GameManagers;
using Fighters.Models.Armors;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.UI
{
    internal class UserInterface
    {
        private GameManager _gameManager = new GameManager();
        public void Play()
        {
            Console.WriteLine( "Добро пожаловать в игру Fighters! Для начала битвы создайте своего героя." );
            IFighter fighterA = StartFighterInit();
            Console.WriteLine( $"\nПервый герой:\n{fighterA.WriteInfo()}\n" );

            Console.WriteLine( "Теперь ему нужен достойный оппонент, не так ли? Пожалуйста, создайте второго героя." );
            IFighter fighterB = StartFighterInit();
            Console.WriteLine( $"\nВторой герой:\n{fighterB.WriteInfo()}\n" );

            StartBattle( fighterA, fighterB );
        }

        private void StartBattle( IFighter fighterA, IFighter fighterB )
        {
            Console.WriteLine( $"Битва начинается! \nГерой {fighterA.Name}({fighterA.GetCurrentHealth()} ХП) выходит на ринг против {fighterB.Name}({fighterB.GetCurrentHealth()} ХП)" );
            _gameManager.Play( fighterA, fighterB );
        }

        private IFighter StartFighterInit()
        {
            string fName = ReadName();
            IRace fRaceType = ReadRace();
            IFighter fighter = ReadFighter( fName, fRaceType );
            ReadWeapon( fighter );
            ReadArmor( fighter );

            return fighter;
        }

        private string ReadName()
        {
            string? fName = null;
            while ( string.IsNullOrEmpty( fName ) )
            {
                Console.WriteLine( "Пожалуйста, введите имя бойца (оно не должно быть пустым)." );
                fName = Console.ReadLine();
            }

            return fName;
        }

        private IRace ReadRace()
        {
            while ( true )
            {
                Console.WriteLine( "Выберите расу бойца:" );
                RaceFactory.WriteRaceChoice();
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out RaceType rType );
                if ( isParsed )
                {
                    IRace? race = RaceFactory.Create( rType );
                    if ( race != null )
                    {
                        return race;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private IFighter ReadFighter( string name, IRace race )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите класс бойца:" );
                FighterFactory.WriteFightersChoice();
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out FighterType fType );
                if ( isParsed )
                {
                    IFighter? fighter = FighterFactory.Create( fType, name, race );
                    if ( fighter != null )
                    {
                        return fighter;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private void ReadWeapon( IFighter fighter )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите оружие:" );
                WeaponFactory.WriteWeaponChoice();
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out WeaponType wType );
                if ( isParsed )
                {
                    IWeapon? weapon = WeaponFactory.Create( wType );
                    if ( weapon != null )
                    {
                        fighter.SetWeapon( weapon );

                        return;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private void ReadArmor( IFighter fighter )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите броню:" );
                ArmorFactory.WriteArmorChoice();
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out ArmorType aType );
                if ( isParsed )
                {
                    IArmor? armor = ArmorFactory.Create( aType );
                    if ( armor != null )
                    {
                        fighter.SetArmor( armor );

                        return;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }
    }
}