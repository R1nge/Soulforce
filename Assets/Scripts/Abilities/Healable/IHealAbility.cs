namespace Abilities.Healable
{
    public interface IHealAbility
    {
        int GetHeal();
        void ApplyHeal(IHealable healable);
    }
}