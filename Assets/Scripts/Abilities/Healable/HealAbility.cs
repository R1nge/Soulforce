namespace Abilities.Healable
{
    public class HealAbility : IHealAbility
    {
        private readonly int _heal;
        private readonly int _duration;

        public HealAbility(int heal, int duration)
        {
            _heal = heal;
            _duration = duration;
        }

        public int GetHeal() => _heal;

        public int GetDuration() => _duration;

        public void ApplyHeal(IHealable healable) => healable.ApplyHeal(_duration, _heal);
    }
}