using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class CalculateMasculine : ICalculateService<MasculinePlayer>
    {
        public double Calculate(MasculinePlayer applicant)
        {
            return applicant.Lucky < 1.1
                ? applicant.Ability * applicant.Lucky * applicant.Strengh * applicant.VelocityDisplacement * 0.9
                : applicant.Ability * applicant.Lucky * applicant.Strengh * applicant.VelocityDisplacement;
        }
    }
}
