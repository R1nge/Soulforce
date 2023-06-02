using Units;
using UnityEngine;

namespace Cards
{
    public abstract class CardBase : MonoBehaviour
    {
        [SerializeField] protected CardConfig cardConfig;
        [SerializeField] protected CardData cardData;
        [SerializeField] protected UnitBase target;

        private void OnMouseDown() => UseCard();

        protected abstract void UseCard();

        public CardConfig CardConfig => cardConfig;
        public CardData CardData() => cardData;
    }
}