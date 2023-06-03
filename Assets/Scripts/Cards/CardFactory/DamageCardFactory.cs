using Cards.Behaviours;
using Energy;
using Units;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Cards.CardFactory
{
    public class DamageCardFactory : CardFactory
    {
        public override CardBase CreateCard(Vector3 position)
        {
            var card = new DamageCard(cardConfig, cardData, target, EnergyController);
            var cardPrefab = ObjectResolver.Instantiate(CardPrefab, position, Quaternion.identity);
            cardPrefab.Init(card);
            return card;
        }

        public DamageCardFactory(IObjectResolver objectResolver, CardConfig cardConfig, CardData cardData, UnitBase target, CardBehaviour cardPrefab, EnergyController energyController) : base(objectResolver, cardConfig, cardData, target, cardPrefab, energyController)
        {
        }
    }
}