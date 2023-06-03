using UI.Card;
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

        private void OnMouseDown()
        {
            if (_card.TryUseCard())
            {
                Destroy(gameObject);
            }
        }
    }
}