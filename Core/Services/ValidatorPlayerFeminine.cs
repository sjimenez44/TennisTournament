using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class ValidatorPlayerFeminine : IValidator<FemininePlayer>
    {
        public ValidationResult Validator(FemininePlayer value)
        {
            ValidationResult result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(value.Name))
                result.ErrorMessage.Add("El nombre esta vacio.");

            if (value.Ability < 0 || value.Ability > 100)
                result.ErrorMessage.Add("La habilidad debe estar entre 0 y 100.");

            if (value.ReactionTime <= 0)
                result.ErrorMessage.Add("El tiempo de reaccion debe ser mayor a 0.");

            return result;
        }
    }
}
