namespace Abilities.Healable
{
    public class HealAbility : IHealAbility
    {
        private readonly int _heal;
        private readonly DurationType _durationType;

        public HealAbility(int heal, DurationType durationType)
        {
            _heal = heal;
            _durationType = durationType;
        }

        public int GetHeal() => _heal;

        public DurationType GetDurationType() => _durationType;

        public void ApplyHeal(IHealable healable) => healable.ApplyHeal(_durationType, _heal);
    }
}