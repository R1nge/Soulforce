namespace GameFlow
{
    public interface IGameState
    {
        void Enter(GameStateController controller);
        void Exit(GameStateController controller);
    }
}