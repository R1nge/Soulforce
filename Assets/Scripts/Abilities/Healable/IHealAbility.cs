namespace Abilities.Healable
{
    public interface IHealAbility
    {
        int GetHeal();
        HealType GetHealType();
        void ApplyHeal(IHealable healable);
    }
}