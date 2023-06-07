using System;
using GameFlow;
using VContainer;
using VContainer.Unity;

namespace Dice
{
    public class DiceRollController : IInitializable, IDisposable
    {
        private readonly GameStateController _gameStateController;
        private readonly Dice _playerDice = new(), _enemyDice = new();

        public event Action<int, int> OnDiceRolled;
        public event Action OnPlayerWon;
        public event Action OnEnemyWon;
        public event Action OnTie;

        [Inject]
        private DiceRollController(GameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }

        public void Initialize() => _gameStateController.OnStateChanged += Roll;

        private void Roll(IGameState state)
        {
            switch (state)
            {
                case PlayerTurnState:
                    Roll();
                    break;
            }
        }

        private void Roll()
        {
            var playerRoll = _playerDice.Roll();
            var enemyRoll = _enemyDice.Roll();
            OnDiceRolled?.Invoke(playerRoll, enemyRoll);
            if (playerRoll > enemyRoll)
            {
                OnPlayerWon?.Invoke();
            }
            else if (playerRoll < enemyRoll)
            {
                OnEnemyWon?.Invoke();
            }
            else
            {
                OnTie?.Invoke();
            }
        }

        public void Dispose() => _gameStateController.OnStateChanged -= Roll;
    }
}