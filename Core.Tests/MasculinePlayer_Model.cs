using Core.Models;
using Core.Utils;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class MasculinePlayer_Model
    {
        public MasculinePlayer player;

        [SetUp]
        public void SetUp()
        {
            player = new MasculinePlayer()
            {
                Name = "Player M1",
                Ability = 50,
                Strengh = 23,
                VelocityDisplacement = 1.2
            };
        }

        [Test]
        public void MasculinePlayer_NameShoulBeDefined()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(player.Name), $"Name should be defined");
        }

        [Test]
        public void MasculinePlayer_AbilityShoulBeInRange0to100()
        {
            Assert.IsTrue(player.Ability >= 0 || player.Ability <= 100, "Ability should be between 0 to 100");
        }

        [Test]
        public void MasculinePlayer_StrenghShouldBePositive()
        {
            Assert.IsTrue(player.Strengh >= 0, "Strengh should be positive");
        }

        [Test]
        public void MasculinePlayer_VelocityDisplacementShouldBePositive()
        {
            Assert.IsTrue(player.VelocityDisplacement >= 0, "Velocity Displacement should be positive");
        }

        [Test]
        public void MasculinePlayer_CalculateScoreShouldBePositive()
        {
            player.Lucky = RandomExtensions.NextDouble(new System.Random(), 0.5, 1.5);
            Assert.IsTrue(player.Processor.Calculate(player) > 0, "Score should be positive");
        }
    }
}
