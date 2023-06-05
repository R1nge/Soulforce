using TMPro;

namespace UI.Energy
{
    public class EnergyUIView
    {
        private readonly TextMeshProUGUI _energyText;
        public EnergyUIView(TextMeshProUGUI energyText)
        {
            _energyText = energyText;
        }

        public void UpdateEnergy(int energy)
        {
            _energyText.text = energy.ToString();
        }
    }
}