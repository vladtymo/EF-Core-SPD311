namespace Spanish_Tournament.Interfaces
{
    public interface ITournamentService
    {
        void ShowGoalDifferences();
        void ShowMatchDetails(int matchId);
        void ShowMatchesByDate(DateTime date);
        void ShowMatchesByTeam(string teamName);
        void ShowPlayersByGoalDates(DateTime date);
    }
}
