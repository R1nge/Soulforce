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
        private readonly List<Enhance> _enhances = new();
        private TurnController _turnController;

        [Inject]
        protected void Construct(TurnController turnController)
        {
            _turnController = turnController;
        }

        private void Awake() => _turnController.OnTurnEnded += ExecuteEnhances;

        private void ExecuteEnhances()
        {
            foreach (var enhance in _enhances)
            {
                enhance.Execute(this);
            }

            for (var i = _enhances.Count - 1; i >= 0; i--)
            {
                if (_enhances[i].GetDuration() <= 0)
                {
                    _enhances.RemoveAt(i);
                }
            }
        }

        public void TakeDamage(ElementType elementType, int damage)
        {
            health -= Element.TakeDamage(elementType, damage);
            TakeDamageInternal(elementType, damage);
        }

        protected virtual void TakeDamageInternal(ElementType elementType, int damage) => health -= damage;
        public void ApplyHeal(int amount) => ApplyHealInternal(amount);
        protected virtual void ApplyHealInternal(int amount) => health += amount;
        public void AddEnhance(Enhance enhance) => _enhances.Add(enhance);

        private void OnDestroy() => _turnController.OnTurnStarted -= ExecuteEnhances;
    }
}