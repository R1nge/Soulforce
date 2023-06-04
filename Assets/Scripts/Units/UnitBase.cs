using Abilities;
using Abilities.Damageable;
using Abilities.Healable;
using Elements;
using UnityEngine;

namespace Units
{
    public abstract class UnitBase : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] protected int health;
        protected IElement Element;

        public void TakeDamage(ElementType elementType, int damage)
        {
            health -= Element.TakeDamage(elementType, damage);
            TakeDamageInternal(elementType, damage);
        }

        protected abstract void TakeDamageInternal(ElementType elementType, int damage);
        protected abstract void ApplyHealInternal(DurationType durationType, int amount);
        public void ApplyHeal(DurationType type, int amount) => ApplyHealInternal(type, amount);
    }
}