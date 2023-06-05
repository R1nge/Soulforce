using System;
using UnityEngine;

namespace Resource
{
    public abstract class Resource
    {
        private readonly int _maxAmount;
        private int CurrentAmount { get; set; }
        public event Action<int> OnResourceChanged;

        protected Resource(int maxAmount)
        {
            _maxAmount = maxAmount;
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
            OnResourceChanged?.Invoke(CurrentAmount);
            return true;
        }

        public void ResetAmount()
        {
            CurrentAmount = _maxAmount;
            OnResourceChanged?.Invoke(CurrentAmount);
        }
    }
}