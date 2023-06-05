using System;

namespace Elements
{
    public class FireElement : IElement
    {
        public int TakeDamage(ElementType type, int amount)
        {
            switch (type)
            {
                case ElementType.None:
                    return amount;
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