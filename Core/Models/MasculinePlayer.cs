using Core.Interfaces;
using Core.Services;

namespace Core.Models
{
    public class MasculinePlayer : IApplicant
    {
        public string Name { get; set; }
        public int Ability { get; set; }
        public double Lucky { get; set; }
        public double Strengh { get; set; }
        public double VelocityDisplacement { get; set; }
        public ICalculateService<MasculinePlayer> Processor { get; set; } = new CalculateMasculine();
    }
}
