using Cards;
using Cards.Behaviours;
using Cards.CardFactory;
using Energy;
using Units;
using UnityEngine;
using VContainer;

namespace Deck
{
    public class DeckTest : MonoBehaviour
    {
        [SerializeField] protected CardConfig cardConfig;
        [SerializeField] protected CardData cardData;
        [SerializeField] protected UnitBase target;
        [SerializeField] protected CardBehaviour cardBehaviour;
        private DeckController _deckController;
        private CardFactory _cardFactory;
        private IObjectResolver _objectResolver;
        private EnergyController _energyController;

        [Inject]
        private void Construct(IObjectResolver objectResolver, DeckController deckController, EnergyController energyController)
        {
            _objectResolver = objectResolver;
            _deckController = deckController;
            _energyController = energyController;
        }

        private void Awake()
        {
            _cardFactory = new DamageCardFactory(_objectResolver, cardConfig, cardData, target, cardBehaviour, _energyController);

            for (int i = 0; i < 10; i++)
            {
                _deckController.AddCard(_cardFactory.CreateCard(Vector3.zero));
                print(_deckController.DrawCard().CardConfig.CardName);
            }
        }
    }
}