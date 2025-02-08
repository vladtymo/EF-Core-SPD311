using Spanish_Tournament.Interfaces;
using Spanish_Tournament.Services;

Console.WriteLine("Hello, Spanish Football Tournament!");

ITournamentService tournament = new TournamentService();

tournament.ShowMatchesByTeam("Real Madrid");
//tournament.ShowGoalDifferences(); - should be fixed
tournament.ShowMatchDetails(1);
tournament.ShowPlayersByGoalDates(new DateTime(2025, 4, 11));
tournament.ShowMatchesByDate(new DateTime(2025, 4, 11));