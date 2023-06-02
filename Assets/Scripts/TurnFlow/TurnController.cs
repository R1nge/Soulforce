using System;

namespace TurnFlow
{
    public class TurnController
    {
        public event Action OnTurnStarted;
        public event Action OnTurnEnded;

        public void StartTurn() => OnTurnStarted?.Invoke();
        public void EndTurn() => OnTurnEnded?.Invoke();
    }
}