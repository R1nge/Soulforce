namespace Abilities.Damageable
{
    public interface IDamageAbility
    {
        int GetDamage();
        DamageType GetDamageType();
        void ApplyDamage(IDamageable damageable);
    }
}