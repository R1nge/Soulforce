using System;

namespace Units
{
    public class EnemyRobotUnit : EnemyUnit
    {
        protected override void TakeDamageInternal(ElementType elementType, int amount)
        {
            switch (elementType)
            {
                case ElementType.None:
                    health -= amount;
                    break;
                case ElementType.Electric:
                    health -= amount * 2;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(elementType), elementType, null);
            }
        }
    }
}