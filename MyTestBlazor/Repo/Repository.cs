using MyTestBlazor.Models;

namespace MyTestBlazor.Repo;

public class MockGamesRepository : IRepository
{
    private List<Game> _games;

    public MockGamesRepository()
    {
        _games = new List<Game>
        {
            new()
            {
                Name = "Farmila",
                Genre = "Simulator",
                ReleaseDate = DateTime.Today
            },
            new()
            {
                Name = "Vedmachilo",
                Genre = "RPGG",
                ReleaseDate = DateTime.Today
            },
            new()
            {
                Name = "Destroyer",
                Genre = "Action",
                ReleaseDate = new DateTime(2000, 2, 1)
            },
        };
    }

    public List<Game> GetAllGames()
    {
        return _games;
    }
}