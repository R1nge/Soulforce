using Abilities.Damageable;
using Abilities.Healable;
using Elements;
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
            var damageAbility = new DamageAbility(10, 1, ElementType.Electric);
            var healAbility = new HealAbility(10);
            healAbility.ApplyHeal(Player);
            damageAbility.ApplyDamage(Target);
        }
    }
}