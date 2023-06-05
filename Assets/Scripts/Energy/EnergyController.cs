using System;
using Resource;
using TurnFlow;
using VContainer;
using VContainer.Unity;

namespace Energy
{
    public class EnergyController : IInitializable, IStartable, IDisposable
    {
        private readonly EnergyResource _energyResource = new(200);
        private readonly TurnController _turnController;

        [Inject]
        public EnergyController(TurnController turnController)
        {
            _turnController = turnController;
        }

        public void Initialize() => _turnController.OnTurnStarted += ResetEnergy;

        public void Start() => _energyResource.ResetAmount();

        public Resource.Resource GetEnergyResource() => _energyResource;

        private void ResetEnergy() => _energyResource.ResetAmount();

        public void Dispose() => _turnController.OnTurnStarted -= ResetEnergy;
    }
}