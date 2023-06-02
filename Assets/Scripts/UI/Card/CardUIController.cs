using Cards;
using UnityEngine;

namespace UI.Card
{
    public class CardUIController : MonoBehaviour
    {
        [SerializeField] private CardUIModel cardModel;
        [SerializeField] private CardData cardData;
        private CardUIView _cardView;

        private void Awake()
        {
            _cardView = new(cardModel.cardSpriteRenderer);
        }

        private void Start()
        {
            Init();
        }

        private void Init()
        {
            _cardView.SetCardImage(cardData.CardImage);
        }
    }
}