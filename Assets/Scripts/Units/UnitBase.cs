using System.Collections.Generic;
using Abilities.Damageable;
using Abilities.Healable;
using Elements;
using Enhances;
using TurnFlow;
using UnityEngine;
using VContainer;

namespace Units
{
    public abstract class UnitBase : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] protected int health;
        protected IElement Element;
        private List<Enhance> _enhances = new();
        private TurnController _turnController;

        [Inject]
        protected void Construct(TurnController turnController)
        {
            _turnController = turnController;
        }

        private void Awake()
        {
            _turnController.OnTurnEnded += ExecuteEnhances;
        }

        private void ExecuteEnhances()
        {
            foreach (var enhance in _enhances)
            {
                enhance.Execute(this);
            }
        }

        public void TakeDamage(ElementType elementType, int damage)
        {
            health -= Element.TakeDamage(elementType, damage);
            TakeDamageInternal(elementType, damage);
        }

        protected abstract void TakeDamageInternal(ElementType elementType, int damage);
        protected abstract void ApplyHealInternal(int duration, int amount);
        public void ApplyHeal(int duration, int amount) => ApplyHealInternal(duration, amount);
        public void AddEnhance(Enhance enhance) => _enhances.Add(enhance);
        public void RemoveEnhance(Enhance enhance) => _enhances.Remove(enhance);

        private void OnDestroy()
        {
            _turnController.OnTurnStarted -= ExecuteEnhances;
        }
    }
}