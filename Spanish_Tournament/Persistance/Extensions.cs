using Microsoft.EntityFrameworkCore;
using Spanish_Tournament.Entities;

namespace Spanish_Tournament.Persistance;

public static class Extensions
{
    public static void SeedInitialData(this ModelBuilder modelBuilder)
    {
        // Seed countries
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "Germany" },
            new Country { Id = 2, Name = "France" },
            new Country { Id = 3, Name = "Spain" },
            new Country { Id = 4, Name = "Italy" },
            new Country { Id = 5, Name = "England" }
        );

        // Seed cities
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Berlin", CountryId = 1 },
            new City { Id = 2, Name = "Munich", CountryId = 1 },
            new City { Id = 3, Name = "Paris", CountryId = 2 },
            new City { Id = 4, Name = "Lyon", CountryId = 2 },
            new City { Id = 5, Name = "Madrid", CountryId = 3 },
            new City { Id = 6, Name = "Barcelona", CountryId = 3 },
            new City { Id = 7, Name = "Rome", CountryId = 4 },
            new City { Id = 8, Name = "Milan", CountryId = 4 },
            new City { Id = 9, Name = "London", CountryId = 5 },
            new City { Id = 10, Name = "Manchester", CountryId = 5 }
        );

        // Seed teams
        modelBuilder.Entity<Team>().HasData(
            new Team { Id = 1, Name = "Bayern Munich", CityId = 1, Wins = 25, Loses = 3, Draws = 2 },
            new Team { Id = 2, Name = "Borussia Dortmund", CityId = 2, Wins = 20, Loses = 5, Draws = 5 },
            new Team { Id = 3, Name = "Paris Saint-Germain", CityId = 3, Wins = 30, Loses = 0, Draws = 1 },
            new Team { Id = 4, Name = "Olympique Lyonnais", CityId = 4, Wins = 15, Loses = 10, Draws = 5 },
            new Team { Id = 5, Name = "Real Madrid", CityId = 5, Wins = 28, Loses = 2, Draws = 3 },
            new Team { Id = 6, Name = "FC Barcelona", CityId = 6, Wins = 22, Loses = 6, Draws = 4 },
            new Team { Id = 7, Name = "Juventus", CityId = 7, Wins = 18, Loses = 9, Draws = 3 },
            new Team { Id = 8, Name = "AC Milan", CityId = 8, Wins = 20, Loses = 7, Draws = 3 },
            new Team { Id = 9, Name = "Manchester United", CityId = 9, Wins = 24, Loses = 4, Draws = 4 },
            new Team { Id = 10, Name = "Manchester City", CityId = 10, Wins = 26, Loses = 3, Draws = 4 }
        );

        // Seed positions
        modelBuilder.Entity<Position>().HasData(
            new Position { Id = 1, Name = "Goalkeeper" },
            new Position { Id = 2, Name = "Defender" },
            new Position { Id = 3, Name = "Midfielder" },
            new Position { Id = 4, Name = "Forward" }
        );

        // Seed players
        modelBuilder.Entity<Player>().HasData(
            new Player { Id = 1, FirstName = "Manuel", LastName = "Neuer", Number = 1, Birthdate = new DateTime(1986, 3, 27), TeamId = 1, PositionId = 1 },
            new Player { Id = 2, FirstName = "Robert", LastName = "Lewandowski", Number = 9, Birthdate = new DateTime(1988, 8, 21), TeamId = 1, PositionId = 4 },
            new Player { Id = 3, FirstName = "Kylian", LastName = "Mbappé", Number = 7, Birthdate = new DateTime(1998, 12, 20), TeamId = 3, PositionId = 4 },
            new Player { Id = 4, FirstName = "Neymar", LastName = "Jr", Number = 11, Birthdate = new DateTime(1992, 2, 5), TeamId = 3, PositionId = 4 },
            new Player { Id = 5, FirstName = "Lionel", LastName = "Messi", Number = 10, Birthdate = new DateTime(1987, 6, 24), TeamId = 6, PositionId = 4 },
            new Player { Id = 6, FirstName = "Sergio", LastName = "Ramos", Number = 4, Birthdate = new DateTime(1986, 3, 30), TeamId = 5, PositionId = 2 },
            new Player { Id = 7, FirstName = "Cristiano", LastName = "Ronaldo", Number = 7, Birthdate = new DateTime(1985, 2, 5), TeamId = 9, PositionId = 4 },
            new Player { Id = 8, FirstName = "Harry", LastName = "Kane", Number = 9, Birthdate = new DateTime(1993, 7, 28), TeamId = 9, PositionId = 4 },
            new Player { Id = 9, FirstName = "Paul", LastName = "Pogba", Number = 6, Birthdate = new DateTime(1993, 3, 15), TeamId = 9, PositionId = 3 },
            new Player { Id = 10, FirstName = "Kevin", LastName = "De Bruyne", Number = 17, Birthdate = new DateTime(1991, 6, 28), TeamId = 10, PositionId = 3 }
        );

        // Seed matches
        modelBuilder.Entity<Match>().HasData(
            new Match { Id = 1, Date = new DateTime(2025, 4, 10), HomeTeamId = 1, GuestTeamId = 2 },
            new Match { Id = 2, Date = new DateTime(2025, 4, 11), HomeTeamId = 3, GuestTeamId = 4 },
            new Match { Id = 3, Date = new DateTime(2025, 4, 12), HomeTeamId = 5, GuestTeamId = 6 },
            new Match { Id = 4, Date = new DateTime(2025, 4, 13), HomeTeamId = 7, GuestTeamId = 8 },
            new Match { Id = 5, Date = new DateTime(2025, 4, 14), HomeTeamId = 2, GuestTeamId = 3 },
            new Match { Id = 6, Date = new DateTime(2025, 4, 15), HomeTeamId = 6, GuestTeamId = 7 },
            new Match { Id = 7, Date = new DateTime(2025, 4, 16), HomeTeamId = 8, GuestTeamId = 1 },
            new Match { Id = 8, Date = new DateTime(2025, 4, 17), HomeTeamId = 4, GuestTeamId = 10 },
            new Match { Id = 9, Date = new DateTime(2025, 4, 18), HomeTeamId = 9, GuestTeamId = 5 },
            new Match { Id = 10, Date = new DateTime(2025, 4, 19), HomeTeamId = 10, GuestTeamId = 2 }
        );

        // Seed goals
        modelBuilder.Entity<Goal>().HasData(
            // Match 1: Bayern Munich vs Borussia Dortmund
            new Goal { Id = 1, Minute = 34, MatchId = 1, PlayerId = 2, TeamId = 1 },
            new Goal { Id = 2, Minute = 58, MatchId = 1, PlayerId = 2, TeamId = 1 },
            new Goal { Id = 3, Minute = 78, MatchId = 1, PlayerId = 7, TeamId = 2 },

            // Match 2: Paris Saint-Germain vs Olympique Lyonnais
            new Goal { Id = 4, Minute = 21, MatchId = 2, PlayerId = 3, TeamId = 3 },
            new Goal { Id = 5, Minute = 59, MatchId = 2, PlayerId = 4, TeamId = 3 },

            // Match 3: Real Madrid vs FC Barcelona
            new Goal { Id = 6, Minute = 43, MatchId = 3, PlayerId = 5, TeamId = 6 },
            new Goal { Id = 7, Minute = 68, MatchId = 3, PlayerId = 6, TeamId = 5 },
            new Goal { Id = 8, Minute = 89, MatchId = 3, PlayerId = 5, TeamId = 6 },

            // Match 4: Juventus vs AC Milan
            new Goal { Id = 9, Minute = 16, MatchId = 4, PlayerId = 7, TeamId = 7 },
            new Goal { Id = 10, Minute = 47, MatchId = 4, PlayerId = 8, TeamId = 8 },

            // Match 5: Borussia Dortmund vs Paris Saint-Germain
            new Goal { Id = 11, Minute = 23, MatchId = 5, PlayerId = 2, TeamId = 2 },
            new Goal { Id = 12, Minute = 77, MatchId = 5, PlayerId = 3, TeamId = 3 },

            // Match 6: FC Barcelona vs Juventus
            new Goal { Id = 13, Minute = 38, MatchId = 6, PlayerId = 5, TeamId = 6 },
            new Goal { Id = 14, Minute = 60, MatchId = 6, PlayerId = 7, TeamId = 7 },

            // Match 7: AC Milan vs Bayern Munich
            new Goal { Id = 15, Minute = 32, MatchId = 7, PlayerId = 8, TeamId = 8 },
            new Goal { Id = 16, Minute = 50, MatchId = 7, PlayerId = 2, TeamId = 1 },

            // Match 8: Olympique Lyonnais vs Manchester City
            new Goal { Id = 17, Minute = 28, MatchId = 8, PlayerId = 4, TeamId = 3 },
            new Goal { Id = 18, Minute = 65, MatchId = 8, PlayerId = 10, TeamId = 10 },

            // Match 9: Manchester United vs Real Madrid
            new Goal { Id = 19, Minute = 14, MatchId = 9, PlayerId = 7, TeamId = 9 },
            new Goal { Id = 20, Minute = 59, MatchId = 9, PlayerId = 6, TeamId = 5 },

            // Match 10: Manchester City vs Borussia Dortmund
            new Goal { Id = 21, Minute = 25, MatchId = 10, PlayerId = 10, TeamId = 10 },
            new Goal { Id = 22, Minute = 72, MatchId = 10, PlayerId = 2, TeamId = 2 }
        );
    }
}
