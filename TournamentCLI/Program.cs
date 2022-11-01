using System;
using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;
using Core.Models;
using Core.Services;
using Core.Utils;

namespace TournamentCLI
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            DoFeminineTournament("Feminine Tennis Tournament");
            Console.WriteLine();
            DoMasculineTournament("Masculine Tennis Tournament");
        }

        public static void DoFeminineTournament(string titleGame)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine(titleGame);
                List<FemininePlayer> listPlayersF = new List<FemininePlayer>()
                {
                    new FemininePlayer() { Name = "Player F1", Ability = 50, ReactionTime = 2, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5)},
                    new FemininePlayer() { Name = "Player F2", Ability = 70, ReactionTime = 2, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5)},
                    new FemininePlayer() { Name = "Player F3", Ability = 67, ReactionTime = 2, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5)},
                    new FemininePlayer() { Name = "Player F4", Ability = 23, ReactionTime = 2, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5)}
                };
                FemininePlayer winnerF = new TournamentFeminine().Game(listPlayersF);
                Console.WriteLine($"Winner {winnerF.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DoMasculineTournament(string titleGame)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine(titleGame);
                List<MasculinePlayer> listPlayersM = new List<MasculinePlayer>()
                {
                    new MasculinePlayer() { Name = "Player M1", Ability = 50, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M2", Ability = 70, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M3", Ability = 67, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M4", Ability = 23, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M5", Ability = 50, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M6", Ability = 70, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M7", Ability = 67, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1},
                    new MasculinePlayer() { Name = "Player M8", Ability = 23, Lucky = RandomExtensions.NextDouble(random, 0.5, 1.5), Strengh = 10, VelocityDisplacement = 1.1}
                };
                MasculinePlayer winnerM = new TournamentMasculine().Game(listPlayersM);
                Console.WriteLine($"Winner {winnerM.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
