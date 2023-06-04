namespace Units
{
    public abstract class EnemyUnit : UnitBase
    {
        protected override void ApplyHealInternal(int duration, int amount)
        {
            health += amount;
        }
    }
}