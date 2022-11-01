using Core.Interfaces;
using Core.Models;
using Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class ValidatorTournamentMasculine : IValidator<List<MasculinePlayer>>
    {
        public ValidationResult Validator(List<MasculinePlayer> value)
        {
            ValidationResult result = new ValidationResult();

            if (!MathExtensions.EsPotencia2(value.Count))
                result.ErrorMessage.Add("La lista no es potencia de 2.");

            return result;
        }
    }
}
