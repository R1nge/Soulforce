using Elements;

namespace Abilities.Damageable
{
    public class DamageAbility : IDamageAbility
    {
        private readonly int _damage;
        private readonly ElementType _elementType;

        public DamageAbility(int damage, ElementType elementType)
        {
            _damage = damage;
            _elementType = elementType;
        }

        public int GetDamage() => _damage;
        public ElementType GetElementType() => _elementType;
        public void ApplyDamage(IDamageable damageable) => damageable.TakeDamage(_elementType, _damage);
    }
}