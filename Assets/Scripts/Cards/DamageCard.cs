using Abilities.Damageable;
using Energy;
using Units;

namespace Cards
{
    public class DamageCard : CardBase
    {
        public DamageCard(CardConfig cardConfig, CardData cardData, UnitBase target, EnergyController energyController) : base(cardConfig, cardData, target, energyController)
        {
        }

        protected override void UseCard()
        {
            var damageAbility = new DamageAbility(10, DamageType.Physical);
            damageAbility.ApplyDamage(Target);
        }
    }
}