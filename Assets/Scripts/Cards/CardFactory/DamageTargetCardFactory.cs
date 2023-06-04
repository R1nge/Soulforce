using Cards.Behaviours;
using Energy;
using Units;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Cards.CardFactory
{
    public class DamageTargetCardFactory : CardFactory
    {
        public DamageTargetCardFactory(IObjectResolver objectResolver, CardConfig cardConfig, CardData cardData, UnitBase player, CardBehaviour cardPrefab, EnergyController energyController) : base(objectResolver, cardConfig, cardData, player, cardPrefab, energyController)
        {
        }

        public override CardBase CreateCard(Vector3 position, Transform parent)
        {
            var card = new SingleElectricDamageTargetCard(Player, CardConfig, CardData, EnergyController);
            var cardPrefab = ObjectResolver.Instantiate(CardPrefab, position, Quaternion.identity, parent);
            cardPrefab.transform.localPosition = position;
            cardPrefab.Init(card);
            return card;
        }
    }
}