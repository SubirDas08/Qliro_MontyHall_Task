using MontyHall_Library;

namespace MontyHall.Tests
{
    public class MontyHallGameTests
    {
        /// <summary>
        /// Verifies that when the player switches doors, the win rate is greater than 0.6.
        ///</summary>
        [Fact]
        public void TestSimulateSwitchDoors()
        {
            int simulations = 1000;
            bool switchDoors = true;
            MontyHallGame game = new MontyHallGame(simulations, switchDoors);
            game.Simulate();
            double winRate = (double)game.Wins / simulations;
            Assert.True(winRate > 0.6);
        }

        /// <summary>
        /// Verifies that when the player does not switch doors, the win rate is less than 0.4.
        ///</summary>
        [Fact]
        public void TestSimulateNotSwitchDoors()
        {
            int simulations = 1000;
            bool switchDoors = false;
            MontyHallGame game = new MontyHallGame(simulations, switchDoors);
            game.Simulate();
            double winRate = (double)game.Wins / simulations;
            Assert.True(winRate < 0.4);
        }
    }
}