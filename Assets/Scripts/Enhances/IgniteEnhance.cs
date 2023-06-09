﻿using Elements;
using Units;
using UnityEngine;

namespace Enhances
{
    public class IgniteEnhance : Enhance
    {
        public IgniteEnhance(int duration) : base(duration)
        {
        }

        public override void Execute(UnitBase target)
        {
            Debug.Log($"Ignite {target.name}");
            target.TakeDamage(ElementType.Fire,10);
            base.Execute(target);
        }
    }
}