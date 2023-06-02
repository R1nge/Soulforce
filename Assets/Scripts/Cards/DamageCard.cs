using Abilities.Damageable;

namespace Cards
{
    public class DamageCard : CardBase
    {
        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, DamageType.Physical);
            damageAbility.ApplyDamage(target);
            Destroy(gameObject);
        }
    }
}