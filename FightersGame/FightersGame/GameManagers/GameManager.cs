using Fighters.Models.Fighters;
using Fighters.Extensions;

namespace Fighters.GameManagers
{
    public class GameManager
    {
        private List<int> criticalSteps = [ 20, 30, 40, 50, 60 ];
        public IFighter Play( IFighter fighterA, IFighter fighterB )
        {
            int step = 0;
            bool isFighterAActive = IsFighterAActive( fighterA, fighterB );
            while ( fighterA.IsAlive() && fighterB.IsAlive() )
            {
                step++;
                Console.WriteLine( $"----- Ход {step} -" );
                if ( criticalSteps.Contains( step ) )
                {
                    Console.WriteLine( $"\nЗатяжной бой сказывается на броне воинов, применяется дебафф к ёё прочности!\n" );
                    double debuff = 0.2 * ( criticalSteps.IndexOf( step ) + 1 );
                    fighterA.timeArmorDebuff( debuff );
                    fighterB.timeArmorDebuff( debuff );
                }

                if ( isFighterAActive )
                {
                    Console.WriteLine( $"Атака бойца {fighterA.Name}." );
                    fighterB.BeAttacked( fighterA );
                    Console.WriteLine( $"Удар! У бойца {fighterB.Name} остаётся {fighterB.GetCurrentHealth():F2} ХП." );
                    isFighterAActive = false;
                }
                else
                {
                    Console.WriteLine( $"Атака бойца {fighterB.Name}." );
                    fighterA.BeAttacked( fighterB );
                    Console.WriteLine( $"Удар! У бойца {fighterA.Name} остаётся {fighterA.GetCurrentHealth():F2} ХП." );
                    isFighterAActive = true;
                }
            }
            IFighter winner = fighterA.IsAlive() ? fighterA : fighterB;
            Console.WriteLine( $"\nПобедителем из этой схватки выходит {winner.Name}!" );

            return winner;
        }

        private bool IsFighterAActive( IFighter fighterA, IFighter fighterB )
        {
            Random rnd = new Random();
            int rndInt = rnd.Next();
            if ( fighterA.IsFirst( fighterB ) || ( fighterA.HaveTheSamePriority( fighterB ) && rndInt % 2 == 1 ) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}