using GameFlow;
using UnityEngine;
using VContainer;

namespace UI.TurnFlow
{
    public class TurnManagerUIController : MonoBehaviour
    {
        [SerializeField] private TurnManagerUIModel model;
        private TurnManagerUIView _view;
        private GameStateController _gameStateController;

        [Inject]
        private void Construct(GameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }

        private void Awake()
        {
            _view = new(model.endTurnButton);
            _gameStateController.OnStateEntered += _view.OnPlayerTurnStarted;
            _gameStateController.OnStateExited += _view.OnPlayerTurnEnded;
        }

        public void EndTurn() => _gameStateController.EndTurn();

        private void OnDestroy()
        {
            _gameStateController.OnStateEntered -= _view.OnPlayerTurnStarted;
            _gameStateController.OnStateExited -= _view.OnPlayerTurnEnded;
        }
    }
}