using Energy;
using Units;

namespace Cards
{
    public abstract class CardBase
    {
        private readonly CardData _cardData;
        protected UnitBase Target;
        protected readonly UnitBase Player;
        private readonly EnergyController _energyController;

        protected CardBase(UnitBase player, CardConfig cardConfig, CardData cardData, EnergyController energyController)
        {
            Player = player;
            CardConfig = cardConfig;
            _cardData = cardData;
            _energyController = energyController;
        }

        public CardConfig CardConfig { get; }

        protected abstract void UseCard();
        
        public bool TryUseCard(UnitBase target)
        {
            if (!CanUseCard()) return false;
            Target = target;
            UseCard();
            return true;
        }

        private bool CanUseCard() => _energyController.GetEnergyResource().TrySpend(_cardData.energyCost);
    }
}