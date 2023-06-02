using UnityEngine;

namespace UI.Unit
{
    public class UnitUIView
    {
        private readonly SpriteRenderer _spriteRenderer;

        public UnitUIView(SpriteRenderer spriteRenderer)
        {
            _spriteRenderer = spriteRenderer;
        }

        public void SetSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }
    }
}