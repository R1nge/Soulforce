using System;
using TMPro;
using UnityEngine.UI;

namespace UI.Card
{
    [Serializable]
    public class CardUIModel
    {
        public TextMeshProUGUI name;
        public RawImage image;
        public TextMeshProUGUI description;
    }
}