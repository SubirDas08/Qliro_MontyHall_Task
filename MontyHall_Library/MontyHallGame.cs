namespace MontyHall_Library
{
    public class MontyHallGame
    {
        private int _simulations;
        private bool _switchDoors;
        private Random _rnd;

        public int Wins { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MontyHallGame class.
        /// </summary>
        /// <param name="simulations">The number of simulations to run.</param>
        /// <param name="switchDoors">Indicates whether the player will switch doors during the game.</param>
        public MontyHallGame(int simulations, bool switchDoors)
        {
            _simulations = simulations;
            _switchDoors = switchDoors;
            _rnd = new Random();
            Wins = 0;
        }

        /// <summary>
        /// Runs the Monty Hall game simulation for the specified number of times.
        ///</summary>
        public void Simulate()
        {
            for (int i = 0; i < _simulations; i++)
            {
                int carDoor = _rnd.Next(1, 4);
                int playerChoice = _rnd.Next(1, 4);

                if (_switchDoors && playerChoice != carDoor || !_switchDoors && playerChoice == carDoor)
                {
                    Wins++;
                }
            }
        }
    }
}