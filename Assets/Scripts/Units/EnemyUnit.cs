using Abilities;

namespace Units
{
    public abstract class EnemyUnit : UnitBase
    {
        protected override void ApplyHealInternal(DurationType durationType, int amount)
        {
            health += amount;
        }
    }
}