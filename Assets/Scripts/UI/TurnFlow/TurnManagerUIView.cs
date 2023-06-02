using UnityEngine.UI;

namespace UI.TurnFlow
{
    public class TurnManagerUIView
    {
        private readonly Button _endTurnButton;

        public TurnManagerUIView(Button endTurnButton)
        {
            _endTurnButton = endTurnButton;
        }

        public void OnTurnControllerStarted()
        {
            _endTurnButton.interactable = true;
        }

        public void OnTurnControllerEnded()
        {
            _endTurnButton.interactable = false;
        }
    }
}