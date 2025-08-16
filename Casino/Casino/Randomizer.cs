namespace Casino
{
    internal class Randomizer
    {
        private readonly Random _random;

        public Randomizer()
        {
            _random = new Random();
        }

        public int GenerateRandomNumber( int min, int max )
        {
            return _random.Next( min, max + 1 );
        }
    }
}