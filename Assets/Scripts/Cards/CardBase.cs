using Units;
using UnityEngine;

namespace Cards
{
    public abstract class CardBase : MonoBehaviour
    {
        [SerializeField] protected UnitBase target;

        private void OnMouseDown() => UseCard();

        protected abstract void UseCard();
    }
}