using Abilities.Damageable;
using Abilities.Healable;
using Units;
using UnityEngine;

public class AddAbility : MonoBehaviour
{
    [SerializeField] private UnitBase unit;

    private void Start()
    {
        AddAbilityTo();
    }

    private void AddAbilityTo()
    {
        var healAbility = new HealAbility(10, HealType.Single);
        healAbility.ApplyHeal(unit);
        var damageAbility = new DamageAbility(10, DamageType.Physical);
        damageAbility.ApplyDamage(unit);
    }
}