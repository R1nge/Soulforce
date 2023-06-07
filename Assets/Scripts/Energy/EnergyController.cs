using System;
using GameFlow;
using Resource;
using VContainer;
using VContainer.Unity;

namespace Energy
{
    public class EnergyController : IInitializable, IStartable, IDisposable
    {
        private readonly EnergyResource _energyResource = new(200);
        private readonly GameStateController _gameStateController;

        [Inject]
        public EnergyController(GameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }

        public void Initialize() => _gameStateController.OnStateEntered += ResetEnergy;

        public void Start() => _energyResource.ResetAmount();

        public Resource.Resource GetEnergyResource() => _energyResource;

        private void ResetEnergy(IGameState state)
        {
            switch (state)
            {
                case PlayerTurnState:
                    _energyResource.ResetAmount();
                    break;
            }
        }

        public void Dispose() => _gameStateController.OnStateEntered -= ResetEnergy;
    }
}