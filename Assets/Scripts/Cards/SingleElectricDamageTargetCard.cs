using Abilities.Damageable;
using Energy;
using Enhances;
using Units;

namespace Cards
{
    public class SingleElectricDamageTargetCard : CardBase
    {
        public SingleElectricDamageTargetCard(UnitBase player, CardConfig cardConfig, CardData cardData, EnergyController energyController) : base(player, cardConfig, cardData, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, 2, ElementType.Electric);
            Target.AddEnhance(new IgniteEnhance(2));
            damageAbility.ApplyDamage(Target);
        }
    }
}