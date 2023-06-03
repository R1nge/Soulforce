using Cards;
using UnityEngine;

namespace UI.Card
{
    public class CardUIController : MonoBehaviour
    {
        [SerializeField] private CardUIModel cardModel;
        private CardUIView _cardView;

        private void Awake()
        {
            _cardView = new(cardModel.name,cardModel.image, cardModel.description);
        }

        public void Init(CardBase card)
        {
            _cardView.SetCardName(card.CardConfig.CardName);
            _cardView.SetCardImage(card.CardConfig.CardImage);
            _cardView.SetCardDescription(card.CardConfig.CardDescription);
        }
    }
}