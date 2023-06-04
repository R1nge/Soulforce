using Abilities;
using Abilities.Damageable;
using Abilities.Healable;
using UnityEngine;

namespace Units
{
    public abstract class UnitBase : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] protected int health;

        public void TakeDamage(ElementType elementType, int damage) => TakeDamageInternal(elementType, damage);
        protected abstract void TakeDamageInternal(ElementType elementType, int amount);
        protected abstract void ApplyHealInternal(DurationType durationType, int amount);
        public void ApplyHeal(DurationType type, int amount) => ApplyHealInternal(type, amount);
    }
}