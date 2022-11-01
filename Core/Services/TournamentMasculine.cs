using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class TournamentMasculine : IGame<MasculinePlayer>
    {
        public MasculinePlayer Game(List<MasculinePlayer> listOfPlayers)
        {
            ValidatorTournamentMasculine validatorTournament = new ValidatorTournamentMasculine();
            ValidationResult resultValidation = validatorTournament.Validator(listOfPlayers);

            if (resultValidation.IsValid)
            {
                ValidatorPlayerMasculine validatorPlayer = new ValidatorPlayerMasculine();
                bool validatePlayers = listOfPlayers
                    .Select(f => validatorPlayer.Validator(f).IsValid)
                    .All(c => c == true);
                if (validatePlayers)
                {
                    CheckStageMasculine checkStage = new CheckStageMasculine();
                    List<MasculinePlayer> listStage = checkStage.Check(listOfPlayers);
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
