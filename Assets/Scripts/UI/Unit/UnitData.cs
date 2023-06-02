using UnityEngine;

namespace UI.Unit
{
    [CreateAssetMenu(fileName = "UnitData", menuName = "UnitData")]
    public class UnitData : ScriptableObject
    {
        [SerializeField] private Sprite sprite;
        public Sprite Sprite => sprite;
    }
}