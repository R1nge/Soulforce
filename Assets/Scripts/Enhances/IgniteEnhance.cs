using Units;
using UnityEngine;

namespace Enhances
{
    public class IgniteEnhance : Enhance
    {
        public override void Execute(UnitBase target)
        {
            Debug.Log($"Ignite {target.name}");
            target.TakeDamage(ElementType.Electric,1000);
            base.Execute(target);
        }
    }
}