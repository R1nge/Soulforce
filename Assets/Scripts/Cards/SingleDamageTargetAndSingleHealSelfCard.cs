using Abilities;
using Abilities.Damageable;
using Abilities.Healable;
using Energy;
using Units;

namespace Cards
{
    public class SingleDamageTargetAndSingleHealSelfCard : CardBase
    {
        public SingleDamageTargetAndSingleHealSelfCard(UnitBase player, CardConfig cardConfig, CardData cardData, EnergyController energyController) : base(player, cardConfig, cardData, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, ElementType.None);
            var healAbility = new HealAbility(10, DurationType.Single);
            healAbility.ApplyHeal(Player);
            damageAbility.ApplyDamage(Target);
        }
    }
}