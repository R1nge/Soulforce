using Elements;
using UnityEngine;

namespace Units
{
    public class PlayerUnit : UnitBase
    {
        protected override void TakeDamageInternal(ElementType elementType, int damage)
        {
            if (health <= 0)
            {
                //TODO: game over
                Debug.Log("Gameover");
            }
        }
    }
}