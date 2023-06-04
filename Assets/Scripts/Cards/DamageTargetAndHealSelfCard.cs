using Abilities.Damageable;
using Abilities.Healable;
using Energy;
using Units;

namespace Cards
{
    public class DamageTargetAndHealSelfCard : CardBase
    {
        public DamageTargetAndHealSelfCard(UnitBase player, CardConfig cardConfig, CardData cardData, EnergyController energyController) : base(player, cardConfig, cardData, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, DamageType.Physical);
            var healAbility = new HealAbility(10, HealType.Single);
            healAbility.ApplyHeal(Player);
            damageAbility.ApplyDamage(Target);
        }
    }
}