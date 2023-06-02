using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(fileName = "CardData", menuName = "CardData", order = 0)]
    public class CardData : ScriptableObject
    {
        [SerializeField] private Sprite cardImage;
        [SerializeField] private string cardName;
        public Sprite CardImage => cardImage;
        public string CardName => cardName;
    }
}