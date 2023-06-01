namespace Abilities.Damageable
{
    public class DamageAbility : IDamageAbility
    {
        private readonly int _damage;
        private readonly DamageType _damageType;

        public DamageAbility(int damage, DamageType damageType)
        {
            _damage = damage;
            _damageType = damageType;
        }

        public int GetDamage() => _damage;

        public DamageType GetDamageType() => _damageType;

        public void ApplyDamage(IDamageable damageable) => damageable.TakeDamage(_damageType, _damage);
    }
}