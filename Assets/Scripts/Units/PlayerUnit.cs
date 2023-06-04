using Abilities;

namespace Units
{
    public class PlayerUnit : UnitBase
    {
        protected override void TakeDamageInternal(ElementType elementType, int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                //Destroy(gameObject);
            }
        }

        protected override void ApplyHealInternal(DurationType durationType, int amount)
        {
            health += amount;
        }
    }
}