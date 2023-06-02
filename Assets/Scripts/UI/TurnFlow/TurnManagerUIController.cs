using TurnFlow;
using UnityEngine;
using VContainer;

namespace UI.TurnFlow
{
    public class TurnManagerUIController : MonoBehaviour
    {
        [SerializeField] private TurnManagerUIModel model;
        private TurnManagerUIView _view;
        private TurnController _turnController;

        [Inject]
        private void Construct(TurnController turnController)
        {
            _turnController = turnController;
        }

        private void Awake()
        {
            _view = new(model.endTurnButton);
            _turnController.OnTurnStarted += _view.OnTurnControllerStarted;
            _turnController.OnTurnEnded += _view.OnTurnControllerEnded;
        }

        public void EndTurn() => _turnController.EndTurn();

        private void OnDestroy()
        {
            _turnController.OnTurnStarted -= _view.OnTurnControllerStarted;
            _turnController.OnTurnEnded -= _view.OnTurnControllerEnded;
        }
    }
}