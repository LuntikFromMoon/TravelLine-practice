using Fighters.Models.Fighters;

namespace Fighters.Extensions
{
    public static class IFighterExtensions
    {
        public static bool IsAlive( this IFighter fighter ) => fighter.GetCurrentHealth() > 0;
        public static bool IsFirst( this IFighter fighterA, IFighter fighterB ) => fighterA.GetLuck() > fighterB.GetLuck();
        public static bool HaveTheSamePriority( this IFighter fighterA, IFighter fighterB ) => fighterA.GetLuck() == fighterB.GetLuck();
    }
}