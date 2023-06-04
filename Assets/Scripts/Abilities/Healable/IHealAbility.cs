namespace Abilities.Healable
{
    public interface IHealAbility
    {
        int GetHeal();
        DurationType GetDurationType();
        void ApplyHeal(IHealable healable);
    }
}