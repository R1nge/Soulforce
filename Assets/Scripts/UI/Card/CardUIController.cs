using Cards;
using UnityEngine;

namespace UI.Card
{
    public class CardUIController : MonoBehaviour
    {
        [SerializeField] private CardUIModel cardModel;
        private CardUIView _cardView;
        private CardBase _card;

        private void Awake()
        {
            _cardView = new(cardModel.name,cardModel.image, cardModel.description);
            _card = GetComponent<CardBase>();
        }

        private void Start()
        {
            Init();
        }

        private void Init()
        {
            _cardView.SetCardName(_card.CardConfig.CardName);
            _cardView.SetCardImage(_card.CardConfig.CardImage);
            _cardView.SetCardDescription(_card.CardConfig.CardDescription);
        }
    }
}