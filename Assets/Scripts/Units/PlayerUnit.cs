using Abilities.Damageable;
using Abilities.Healable;

namespace Units
{
    public class PlayerUnit : UnitBase
    {
        protected override void TakeDamageInternal(DamageType damageType, int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                //Destroy(gameObject);
            }
        }

        protected override void ApplyHealInternal(HealType type, int amount)
        {
            health += amount;
        }
    }
}