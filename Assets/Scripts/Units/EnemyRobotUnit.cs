using Elements;
using UnityEngine;

namespace Units
{
    public class EnemyRobotUnit : EnemyUnit
    {
        public EnemyRobotUnit() => Element = new ElectricElement();
        protected override void TakeDamageInternal(ElementType elementType, int damage)
        {
            if (health <= 0)
            {
                Debug.Log("ROBOT DEAD", this);
                Destroy(gameObject);
            }
        }
    }
}