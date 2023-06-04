using UI.Card;
using Units;
using UnityEngine;

namespace Cards.Behaviours
{
    public class CardBehaviour : MonoBehaviour
    {
        private CardUIController _cardUIController;
        private CardBase _card;

        private void Awake()
        {
            _cardUIController = GetComponent<CardUIController>();
        }

        public void Init(CardBase card)
        {
            _card = card;
            _cardUIController.Init(_card);
        }

        public bool TryUseCard(UnitBase unit)
        {
            if (!_card.TryUseCard(unit)) return false;
            Destroy(gameObject);
            return true;
        }
    }
}