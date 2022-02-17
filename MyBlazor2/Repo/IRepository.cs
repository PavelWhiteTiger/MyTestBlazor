using MyBlazor2.Models;

namespace MyBlazor2.Repo;

public interface IRepository
{
    List<GameModel> GetAllGames();
}