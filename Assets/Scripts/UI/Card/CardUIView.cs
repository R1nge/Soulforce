using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Card
{
    public class CardUIView
    {
        private readonly TextMeshProUGUI _name;
        private readonly RawImage _rawImage;
        private readonly TextMeshProUGUI _description;

        public CardUIView(TextMeshProUGUI name, RawImage rawImage, TextMeshProUGUI description)
        {
            _name = name;
            _rawImage = rawImage;
            _description = description;
        }
        
        public void SetCardName(string newName)
        {
            _name.text = newName;
        }

        public void SetCardImage(Sprite newSprite)
        {
            _rawImage.texture = newSprite.texture;
        }

        public void SetCardDescription(string newDescription)
        {
            _description.text = newDescription;
        }
    }
}