using Units;
using UnityEngine;

namespace Enhances
{
    public abstract class Enhance
    {
        protected int Duration = 2;

        public int GetDuration() => Duration;

        public virtual void Execute(UnitBase target)
        {
            Duration--;
        }
    }
}