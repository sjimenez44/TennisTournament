using Core.Interfaces;
using Core.Models;
using Core.Utils;
using System.Collections.Generic;

namespace Core.Services
{
    public class ValidatorTournamentFeminine : IValidator<List<FemininePlayer>>
    {
        public ValidationResult Validator(List<FemininePlayer> value)
        {
            ValidationResult result = new ValidationResult();

            if (!MathExtensions.EsPotencia2(value.Count))
                result.ErrorMessage.Add("La lista no es potencia de 2.");

            return result;
        }
    }
}
