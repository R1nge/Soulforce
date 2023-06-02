using UnityEngine;

namespace UI.Card
{
    public class CardUIView
    {
        private readonly SpriteRenderer _cardSpriteRenderer;

        public CardUIView(SpriteRenderer cardSpriteRenderer)
        {
            _cardSpriteRenderer = cardSpriteRenderer;
        }

        public void SetCardImage(Sprite newSprite)
        {
            _cardSpriteRenderer.sprite = newSprite;
        }
    }
}