using UnityEngine;

namespace Dice
{
    public class Dice
    {
        public int Roll() => Random.Range(0, 6);
    }
}