using System;
using System.Threading;
using VContainer.Unity;

namespace GameFlow
{
    public class GameStateController : IStartable, IDisposable
    {
        public event Action<IGameState> OnStateEntered;
        public event Action<IGameState> OnStateExited;
        public event Action<IGameState> OnStateChanged;
        private IGameState _currentState;
        private readonly IGameState _enemyTurnState = new EnemyTurnState();
        private readonly IGameState _playerTurnState = new PlayerTurnState();

        public void Start() => StartTurn();

        public void StartTurn() => ChangeState(_playerTurnState);

        public void EndTurn() => ChangeState(_enemyTurnState);

        public void SetPlayerState()
        {
            Thread.Sleep(1000 * 5);
            ChangeState(_playerTurnState);
        }

        public void SetEnemyState() => ChangeState(_enemyTurnState);

        private void ChangeState(IGameState state)
        {
            _currentState?.Exit(this);
            OnStateExited?.Invoke(state);
            _currentState = state;
            OnStateChanged?.Invoke(state);
            _currentState?.Enter(this);
            OnStateEntered?.Invoke(state);
        }

        public void Dispose() => OnStateExited -= ChangeState;
    }
}