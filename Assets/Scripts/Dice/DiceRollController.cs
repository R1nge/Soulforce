using System;
using TurnFlow;
using VContainer;
using VContainer.Unity;

namespace Dice
{
    public class DiceRollController : IInitializable, IDisposable
    {
        private readonly TurnController _turnController;
        private readonly Dice _playerDice = new(), _enemyDice = new();

        public event Action<int, int> OnDiceRolled;
        public event Action OnPlayerWon;
        public event Action OnEnemyWon;
        public event Action OnTie;

        [Inject]
        private DiceRollController(TurnController turnController)
        {
            _turnController = turnController;
        }

        public void Initialize() => _turnController.OnTurnStarted += Roll;

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

        public void Dispose() => _turnController.OnTurnStarted -= Roll;
    }
}