using Microsoft.EntityFrameworkCore;
using Spanish_Tournament.Interfaces;
using Spanish_Tournament.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Spanish_Tournament.Services
{

    internal class TournamentService : ITournamentService
    {
        private readonly TournamentDbContext db;
        public TournamentService()
        {
            db = new TournamentDbContext();
        }

        public void ShowGoalDifferences()
        {
            var teams = db.Teams.Include(x => x.Goals).Select(x => new
            {
                x.Name,
                Golas = x.Goals.Count(),
                Conceded = x.HomeMatches.Sum(j => j.Goals.Count(t => t.TeamId != x.Id))
            });

            foreach (var item in teams)
            {
                Console.WriteLine($"Team {item.Name}: {item.Golas} / {item.Conceded} = {item.Golas - item.Conceded}");
            }
        }

        public void ShowMatchDetails(int matchId)
        {
            var match = db.Matches
                .Include(x => x.HomeTeam) // LEFT JOIN
                .Include(x => x.GuestTeam)
                .Include(x => x.Goals)
                .FirstOrDefault(x => x.Id == matchId);

            Console.WriteLine($"Match {match.Id}: {match.Date}\n" +
                $"Teams: {match.HomeTeam.Name} agains {match.GuestTeam.Name}\n" +
                $"Home Team Goals: {match.Goals.Where(x => x.TeamId == match.HomeTeamId).Count()}\n" +
                $"Guest Team Goals: {match.Goals.Where(x => x.TeamId == match.GuestTeamId).Count()}\n");
        }

        public void ShowMatchesByDate(DateTime date)
        {
            var matches = db.Matches.Where(x => x.Date == date)
                .Include(x => x.HomeTeam)
                .Include(x => x.GuestTeam)
                .ToList();

            foreach (var item in matches)
            {
                Console.WriteLine($"Match {item.Id}: {item.HomeTeam.Name} against {item.GuestTeam.Name}");
            }
        }

        public void ShowMatchesByTeam(string teamName)
        {
            var matches = db.Matches
                .Include(x => x.HomeTeam)
                .Include(x => x.GuestTeam)
                .Where(x => x.GuestTeam.Name == teamName || x.HomeTeam.Name == teamName)
                .ToList();

            foreach (var item in matches)
            {
                Console.WriteLine($"Match {item.Id}: {item.HomeTeam.Name} against {item.GuestTeam.Name}");
            }
        }

        public void ShowPlayersByGoalDates(DateTime date)
        {
            var players = db.Players
                .Include(x => x.Position)
                .Include(x => x.Goals)
                .ThenInclude(x => x.Match)
                .Where(x => x.Goals.Any(x => x.Match.Date == date))
                .ToList();

            foreach (var item in players)
            {
                Console.WriteLine($"Player {item.FirstName} {item.LastName}: {item.Number} - {item.Position.Name}");
            }
        }
    }
}
