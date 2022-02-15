using MyTestBlazor.Models;

namespace MyTestBlazor.Repo;

public interface IRepository
{
    List<Game> GetAllGames();
}