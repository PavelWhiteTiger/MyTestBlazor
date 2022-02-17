using MyBlazor2.Models;

namespace MyBlazor2.Repo;

public class MockGamesRepository : IRepository
{
    private List<GameModel> _games;

    public MockGamesRepository()
    {
        _games = new List<GameModel>
        {
            new()
            {
                Name = "Fly",
                Genre = "Simulator",
                DateRelease = DateTime.Today,
                Image = "https://store-images.s-microsoft.com/image/apps.12184.14191615182441913.28a3299c-623a-4620-a9b8-f4e31f6505e0.b57f07ea-61ed-470d-952a-392830a3bbeb"
                
            },
            new()
            {
                Name = "Vedmachilo",
                Genre = "RPGG",
                DateRelease = DateTime.Today,
                Image = "https://upload.wikimedia.org/wikipedia/ru/a/a2/The_Witcher_3-_Wild_Hunt_Cover.jpg"
            },
            new()
            {
                Name = "Destroyer",
                Genre = "Action",
                DateRelease = new DateTime(2000, 2, 1),
                Image = "https://dota2.ru/img/heroes/outworld_destroyer/outworld_destroyer.png"
            },
        };
    }

    public List<GameModel> GetAllGames()
    {
        return _games;
    }
}