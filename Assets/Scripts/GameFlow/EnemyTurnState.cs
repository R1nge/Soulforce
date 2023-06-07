using UnityEngine;

namespace GameFlow
{
    public class EnemyTurnState : IGameState
    {
        public void Enter(GameStateController controller)
        {
            Debug.Log("ENEMY TURN");
            //TODO: enemy decided what to do
            controller.SetPlayerState();
        }

        public void Exit(GameStateController controller)
        {
            //controller.SetPlayerState();
        }
    }
}