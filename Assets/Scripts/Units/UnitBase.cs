using Abilities.Damageable;
using Abilities.Healable;
using UnityEngine;

namespace Units
{
    public abstract class UnitBase : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] protected int health;

        public void TakeDamage(DamageType damageType, int damage)
        {
            TakeDamageInternal(damageType, damage);
        }

        protected abstract void TakeDamageInternal(DamageType damageType, int damage);

        public void ApplyHeal(HealType type, int amount) => ApplyHealInternal(type, amount);

        protected abstract void ApplyHealInternal(HealType type, int amount);
    }
}