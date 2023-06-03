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

        //TODO: set target with a method, to be able to use card on different targets
        private void OnMouseDown()
        {
            if (_card.TryUseCard())
            {
                Destroy(gameObject);
            }
        }
    }
}