using Cards;
using Cards.Behaviours;
using Cards.CardFactory;
using Energy;
using Units;
using UnityEngine;
using VContainer;

namespace Deck
{
    public class DeckInitializer : MonoBehaviour
    {
        [SerializeField] private Transform deckParent;
        [SerializeField] private CardConfig cardConfig;
        [SerializeField] private CardData cardData;
        [SerializeField] private CardBehaviour cardBehaviour;
        private DeckController _deckController;
        private CardFactory _cardFactory;
        private IObjectResolver _objectResolver;
        private EnergyController _energyController;
        private PlayerUnit _player;

        [Inject]
        private void Construct(IObjectResolver objectResolver, DeckController deckController, EnergyController energyController, PlayerUnit player)
        {
            _objectResolver = objectResolver;
            _deckController = deckController;
            _energyController = energyController;
            _player = player;
        }

        private void Awake()
        {
            _cardFactory = new SingleElectricDamageTargetCardFactory(_objectResolver, cardConfig, cardData, _player, cardBehaviour, _energyController);
            _deckController.AddCard(_cardFactory.CreateCard(Vector3.zero, deckParent));
        }
    }
}