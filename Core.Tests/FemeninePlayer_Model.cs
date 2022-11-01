using Core.Models;
using Core.Utils;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class FemeninePlayer_Model
    {
        public FemininePlayer player;

        [SetUp]
        public void SetUp()
        {
            player = new FemininePlayer()
            {
                Name = "Player F1",
                Ability = 50,
                ReactionTime = 1.2
            };
        }

        [Test]
        public void FemeninePlayer_NameShoulBeDefined()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(player.Name), $"Name should be defined");
        }

        [Test]
        public void FemeninePlayer_AbilityShoulBeInRange0to100()
        {
            Assert.IsTrue(player.Ability >= 0 || player.Ability <= 100, "Ability should be between 0 to 100");
        }

        public void FemeninePlayer_ReactionTimeShouldBePositive()
        {
            Assert.IsTrue(player.ReactionTime >= 0, "Reaction Time should be positive");
        }

        [Test]
        public void FemeninePlayer_CalculateScoreShouldBePositive()
        {
            player.Lucky = RandomExtensions.NextDouble(new System.Random(), 0.5, 1.5);
            Assert.IsTrue(player.Processor.Calculate(player) > 0, "Score should be positive");
        }
    }
}
