namespace Abilities.Damageable
{
    public interface IDamageable
    {
        void TakeDamage(DamageType damageType, int damage);
    }
}