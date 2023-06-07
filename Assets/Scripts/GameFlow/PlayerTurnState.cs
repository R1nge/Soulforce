using UnityEngine;

namespace GameFlow
{
    public class PlayerTurnState : IGameState
    {
        public void Enter(GameStateController controller)
        {
            Debug.Log("Player");
            //TODO: get new from pile
            //controller.SetEnemyState();
        }

        public void Exit(GameStateController controller)
        {
            //controller.SetEnemyState();
        }
    }
}