using Energy;
using Units;
using UnityEngine;
using VContainer;

namespace Cards
{
    public abstract class CardBase : MonoBehaviour
    {
        [SerializeField] protected CardConfig cardConfig;
        [SerializeField] protected CardData cardData;
        [SerializeField] protected UnitBase target;
        private EnergyController _energyController;

        [Inject]
        private void Construct(EnergyController energyController)
        {
            _energyController = energyController;
        }

        public CardConfig CardConfig => cardConfig;
        public CardData CardData() => cardData;

        protected abstract void UseCard();

        private void OnMouseDown() => TryUseCard();

        private void TryUseCard()
        {
            if (!CanUseCard()) return;
            UseCard();
        }

        private bool CanUseCard() => _energyController.GetEnergyResource().TrySpend(cardData.energyCost);
    }
}