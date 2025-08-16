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
                Console.WriteLine( "1-Человек, \n2-Эльф, \n3-Дварф.\nВведите цифру..." );
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out RaceType rType );
                if ( isParsed )
                {
                    try
                    {
                        return RaceFactory.Create( rType );
                    }
                    catch ( Exception e )
                    {
                        Console.WriteLine( "Ваш выбор не поддерживается программой." );
                    }
                }
                else
                {
                    Console.WriteLine( "Ваш выбор не поддерживается программой." );
                }

                Console.WriteLine( "Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private IFighter ReadFighter( string name, IRace race )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите класс бойца:" );
                Console.WriteLine( "1-Гладиатор (больше хп), \n2-Охотник (больше дамаг), \n3-Рыцарь (больше защита).\nВведите цифру..." );
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out FighterType fType );
                if ( isParsed )
                {
                    try
                    {
                        return FighterFactory.Create( fType, name, race );
                    }
                    catch ( Exception e )
                    {
                        Console.WriteLine( "Ваш выбор не поддерживается программой." );
                    }
                }
                else
                {
                    Console.WriteLine( "Ваш выбор не поддерживается программой." );
                }

                Console.WriteLine( "Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private void ReadWeapon( IFighter fighter )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите оружие:" );
                Console.WriteLine( "1-Кулаки, \n2-Лук, \n3-Меч, \n4-Счастливый молот. \nВведите цифру..." );
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out WeaponType wType );
                if ( isParsed )
                {
                    try
                    {
                        fighter.SetWeapon( WeaponFactory.Create( wType ) );

                        return;
                    }
                    catch ( Exception e )
                    {
                        Console.WriteLine( "Ваш выбор не поддерживается программой." );
                    }
                }
                else
                {
                    Console.WriteLine( "Ваш выбор не поддерживается программой." );
                }

                Console.WriteLine( "Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private void ReadArmor( IFighter fighter )
        {
            while ( true )
            {
                Console.WriteLine( "Выберите броню:" );
                Console.WriteLine( "1-Без брони, \n2-Кожаная броня, \n3-Железные доспехи.\nВведите цифру..." );
                string? operationStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( operationStr, out ArmorType aType );
                if ( isParsed )
                {
                    try
                    {
                        fighter.SetArmor( ArmorFactory.Create( aType ) );

                        return;
                    }
                    catch ( Exception e )
                    {
                        Console.WriteLine( "Ваш выбор не поддерживается программой." );
                    }
                }
                else
                {
                    Console.WriteLine( "Ваш выбор не поддерживается программой." );
                }

                Console.WriteLine( "Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }
    }
}