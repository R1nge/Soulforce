using Abilities.Damageable;
using Abilities.Healable;
using Energy;
using Units;

namespace Cards
{
    public class DamageAndHealCard : CardBase
    {
        public DamageAndHealCard(CardConfig cardConfig, CardData cardData, UnitBase target, EnergyController energyController) : base(cardConfig, cardData, target, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, DamageType.Physical);
            var healAbility = new HealAbility(10, HealType.Single);
            healAbility.ApplyHeal(Target);
            damageAbility.ApplyDamage(Target);
        }
    }
}