using System;

namespace Elements
{
    public class ElectricElement : IElement
    {
        public int TakeDamage(ElementType type, int amount)
        {
            switch (type)
            {
                case ElementType.None:
                    return amount;
                case ElementType.Electric:
                    return amount * 2;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}