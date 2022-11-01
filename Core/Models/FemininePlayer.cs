using Core.Interfaces;
using Core.Services;

namespace Core.Models
{
    public class FemininePlayer : IApplicant
    {
        public string Name { get; set; }
        public int Ability { get; set; }
        public double Lucky { get; set; }
        public double ReactionTime { get; set; }
        public ICalculateService<FemininePlayer> Processor { get; set; } = new CalculateFeminine();
    }
}
