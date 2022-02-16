namespace MyTestBlazor.Helpers;

public class GameHandler
{
    public RSPOptions Choose { get; set; }
    public RSPOptions WinCondition { get; set; }
    public RSPOptions LooseCondition { get; set; }
    public string ImageSrc { get; set; }

    public GameState GameResult(GameHandler opponent)
    {
        if (Choose == opponent.Choose)
        {
            return GameState.Draw;
        }

        return LooseCondition == opponent.Choose ? GameState.Loss : GameState.Victory;
    }
}