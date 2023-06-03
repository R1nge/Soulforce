using Cards.Behaviours;
using Energy;
using Units;
using UnityEngine;
using VContainer;

namespace Cards.CardFactory
{
    public abstract class CardFactory
    {
        //TODO: set target with a method, to be able to use card on different targets
        
        protected CardConfig cardConfig;
        protected CardData cardData;
        protected UnitBase target;
        protected CardBehaviour CardPrefab;
        protected IObjectResolver ObjectResolver;
        protected EnergyController EnergyController;

        public CardFactory(IObjectResolver objectResolver, CardConfig cardConfig, CardData cardData, UnitBase target, CardBehaviour cardPrefab, EnergyController energyController)
        {
            this.cardConfig = cardConfig;
            this.cardData = cardData;
            this.target = target;
            ObjectResolver = objectResolver;
            CardPrefab = cardPrefab;
            EnergyController = energyController;
        }

        public abstract CardBase CreateCard(Vector3 position);
    }
}