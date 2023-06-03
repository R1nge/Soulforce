using Energy;
using Units;

namespace Cards
{
    public abstract class CardBase
    {
        private readonly CardData _cardData;
        protected readonly UnitBase Target;
        private readonly EnergyController _energyController;

        protected CardBase(CardConfig cardConfig, CardData cardData, UnitBase target, EnergyController energyController)
        {
            CardConfig = cardConfig;
            _cardData = cardData;
            Target = target;
            _energyController = energyController;
        }

        public CardConfig CardConfig { get; }

        protected abstract void UseCard();

        public bool TryUseCard()
        {
            if (!CanUseCard()) return false;
            UseCard();
            return true;
        }

        private bool CanUseCard() => _energyController.GetEnergyResource().TrySpend(_cardData.energyCost);
    }
}