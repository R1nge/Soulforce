namespace Abilities.Healable
{
    public interface IHealAbility
    {
        int GetHeal();
        int GetDuration();
        void ApplyHeal(IHealable healable);
    }
}