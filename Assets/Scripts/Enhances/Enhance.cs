using Units;
using UnityEngine;

namespace Enhances
{
    public abstract class Enhance
    {
        protected int Duration = 2;

        public virtual void Execute(UnitBase Target)
        {
            Duration--;
            if (Duration <= 0)
            {
                Target.RemoveEnhance(this);
                Debug.Log("Removed");
            }
        }
    }
}