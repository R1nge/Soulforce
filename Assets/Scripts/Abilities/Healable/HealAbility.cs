namespace Abilities.Healable
{
    public class HealAbility : IHealAbility
    {
        private readonly int _heal;

        public HealAbility(int heal)
        {
            _heal = heal;
        }

        public int GetHeal() => _heal;
        
        public void ApplyHeal(IHealable healable) => healable.ApplyHeal( _heal);
    }
}