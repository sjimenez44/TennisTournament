using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class TournamentFeminine : IGame<FemininePlayer>
    {
        public FemininePlayer Game(List<FemininePlayer> listOfPlayers)
        {
            ValidatorTournamentFeminine validatorTournament = new ValidatorTournamentFeminine();
            ValidationResult resultValidation = validatorTournament.Validator(listOfPlayers);

            if (resultValidation.IsValid)
            {
                ValidatorPlayerFeminine validatorPlayer = new ValidatorPlayerFeminine();
                bool validatePlayers = listOfPlayers
                    .Select(f => validatorPlayer.Validator(f).IsValid)
                    .All(c => c == true);
                if (validatePlayers)
                {
                    CheckStageFeminine checkStage = new CheckStageFeminine();
                    List<FemininePlayer> listStage = checkStage.Check(listOfPlayers);
                    while (listStage.Count > 1)
                    {
                        listStage = checkStage.Check(listStage);
                    }
                    return listStage[0];
                }

                throw new Exception("Verificar los datos de entrada de los jugadores.");
            }

            throw new Exception(string.Join(Environment.NewLine, resultValidation.ErrorMessage));
        }
    }
}
