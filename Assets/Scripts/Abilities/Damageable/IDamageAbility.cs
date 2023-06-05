using Elements;

namespace Abilities.Damageable
{
    public interface IDamageAbility
    {
        int GetDamage();
        ElementType GetElementType();
        void ApplyDamage(IDamageable damageable);
    }
}