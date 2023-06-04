using Abilities.Damageable;
using Energy;
using Units;

namespace Cards
{
    public class DamageTargetCard : CardBase
    {
        public DamageTargetCard(UnitBase player, CardConfig cardConfig, CardData cardData, EnergyController energyController) : base(player, cardConfig, cardData, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, DamageType.Physical);
            damageAbility.ApplyDamage(Target);
        }
    }
}