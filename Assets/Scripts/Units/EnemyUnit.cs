using Abilities;

namespace Units
{
    public abstract class EnemyUnit : UnitBase
    {
        protected override void TakeDamageInternal(ElementType elementType, int amount)
        {
            health -= amount;
        }

        protected override void ApplyHealInternal(DurationType durationType, int amount)
        {
            health += amount;
        }
    }
}