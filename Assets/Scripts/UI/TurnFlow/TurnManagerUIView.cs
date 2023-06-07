using System;
using GameFlow;
using UnityEngine;
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

        public void OnPlayerTurnStarted(IGameState state)
        {
            switch (state)
            {
                case PlayerTurnState:
                    _endTurnButton.interactable = true;
                    Debug.Log("INTERACTABLE");
                    break;
            }
        }

        public void OnPlayerTurnEnded(IGameState state)
        {
            _endTurnButton.interactable = false;
            Debug.Log("IN INTERACTABLE");
        }
    }
}