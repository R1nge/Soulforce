namespace Abilities.Damageable
{
    public interface IDamageable
    {
        void TakeDamage(ElementType elementType, int damage);
    }
}