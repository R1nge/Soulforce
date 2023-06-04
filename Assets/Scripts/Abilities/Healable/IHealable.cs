namespace Abilities.Healable
{
    public interface IHealable
    {
        void ApplyHeal(DurationType type, int amount);
    }
}