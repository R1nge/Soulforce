namespace Abilities.Healable
{
    public class HealAbility : IHealAbility
    {
        private readonly int _heal;
        private readonly HealType _healType;

        public HealAbility(int heal, HealType healType)
        {
            _heal = heal;
            _healType = healType;
        }

        public int GetHeal() => _heal;

        public HealType GetHealType() => _healType;

        public void ApplyHeal(IHealable healable) => healable.ApplyHeal(_healType, _heal);
    }
}