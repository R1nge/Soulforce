using System;
using UnityEngine;

namespace Resource
{
    public abstract class Resource
    {
        public int MaxAmount { get; private set; }
        public int CurrentAmount { get; private set; }
        public event Action<int> OnResourceChanged;

        protected Resource(int maxAmount)
        {
            MaxAmount = maxAmount;
            CurrentAmount = maxAmount;
        }

        public virtual bool TrySpend(int amount)
        {
            if (amount < 0)
            {
                Debug.LogError("Cannot spend negative resource");
                return false;
            }

            if (CurrentAmount - amount < 0) return false;
            CurrentAmount -= amount;
            OnResourceChanged?.Invoke(amount);
            return true;
        }

        public void ResetAmount() => CurrentAmount = MaxAmount;
    }
}