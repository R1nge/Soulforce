namespace Abilities.Healable
{
    public interface IHealable
    {
        void ApplyHeal(HealType type, int amount);
    }
}