using Cards.Behaviours;
using Energy;
using Units;
using UnityEngine;
using VContainer;

namespace Cards.CardFactory
{
    public abstract class CardFactory
    {
        protected readonly CardConfig CardConfig;
        protected readonly CardData CardData;
        protected readonly UnitBase Target;
        protected readonly CardBehaviour CardPrefab;
        protected readonly IObjectResolver ObjectResolver;
        protected readonly EnergyController EnergyController;

        protected CardFactory(IObjectResolver objectResolver, CardConfig cardConfig, CardData cardData, UnitBase target, CardBehaviour cardPrefab, EnergyController energyController)
        {
            CardConfig = cardConfig;
            CardData = cardData;
            Target = target;
            ObjectResolver = objectResolver;
            CardPrefab = cardPrefab;
            EnergyController = energyController;
        }
        
        public abstract CardBase CreateCard(Vector3 position);
    }
}