using System;
using Energy;
using UnityEngine;
using VContainer;

namespace UI.Energy
{
    public class EnergyUIController : MonoBehaviour
    {
        [SerializeField] private EnergyUIModel energyUIModel;
        private EnergyUIView _energyView;
        private EnergyController _energyController;

        [Inject]
        private void Construct(EnergyController energyController)
        {
            _energyController = energyController;
        }

        private void Awake()
        {
            _energyView = new(energyUIModel.energyText);
            _energyController.GetEnergyResource().OnResourceChanged += UpdateUI;
        }

        private void UpdateUI(int amount)
        {
            _energyView.UpdateEnergy(amount);
        }

        private void OnDestroy()
        {
            _energyController.GetEnergyResource().OnResourceChanged -= UpdateUI;
        }
    }
}