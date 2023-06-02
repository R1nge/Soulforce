using System;
using TurnFlow;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Energy
{
    //TODO: make an abstract class for resources
    public class EnergyController : IInitializable, IDisposable
    {
        private int _currentEnergy, _maxEnergy;
        private readonly TurnController _turnController;

        [Inject]
        public EnergyController(TurnController turnController)
        {
            _turnController = turnController;
        }

        public void Initialize() => _turnController.OnTurnStarted += ResetEnergy;

        public bool TrySpendEnergy(int amount)
        {
            if (amount < 0)
            {
                Debug.LogError("Cannot spend negative energy");
                return false;
            }

            if (_currentEnergy - amount < 0) return false;
            _currentEnergy -= amount;
            return true;
        }

        private void ResetEnergy() => _currentEnergy = _maxEnergy;

        public void Dispose() => _turnController.OnTurnStarted -= ResetEnergy;
    }
}