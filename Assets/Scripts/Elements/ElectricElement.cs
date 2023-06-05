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
                case ElementType.Fire:
                    return amount / 2;
                case ElementType.Electric:
                case ElementType.Water:
                    return amount * 2;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}