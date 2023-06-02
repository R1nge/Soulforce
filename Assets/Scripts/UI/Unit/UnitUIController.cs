using System;
using UnityEngine;

namespace UI.Unit
{
    public class UnitUIController : MonoBehaviour
    {
        [SerializeField] private UnitData unitData;
        [SerializeField] private UnitUIModel unitModel;
        private UnitUIView _uiView;

        private void Awake()
        {
            _uiView = new(unitModel.spriteRenderer);
        }

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _uiView.SetSprite(unitData.Sprite);
        }
    }
}