using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(fileName = "CardData", menuName = "CardData")]
    public class CardConfig : ScriptableObject
    {
        [SerializeField] private string cardName;
        [SerializeField] private Sprite cardImage;
        [SerializeField] private string cardDescription;
        public Sprite CardImage => cardImage;
        public string CardName => cardName;
        public string CardDescription => cardDescription;
    }
}