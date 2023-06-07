using System.Collections.Generic;
using Abilities.Damageable;
using Abilities.Healable;
using Elements;
using Enhances;
using GameFlow;
using UnityEngine;
using VContainer;

namespace Units
{
    public abstract class UnitBase : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] protected int health;
        protected IElement Element;
        private List<Enhance> _enhances = new();
        private GameStateController _gameStateController;

        [Inject]
        protected void Construct(GameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }

        private void Awake() => _gameStateController.OnStateExited += ExecuteEnhances;

        private void ExecuteEnhances(IGameState state)
        {
            if (_enhances == null)
            {
                Debug.LogWarning("Enhances are null", this);
                return;
            }

            for (var i = 0; i < _enhances.Count; i++)
            {
                _enhances[i].Execute(this);
            }

            for (var i = _enhances.Count - 1; i >= 0; i--)
            {
                if (_enhances[i].GetDuration() <= 0)
                {
                    _enhances.RemoveAt(i);
                }
            }
        }

        protected virtual void TakeDamageInternal(ElementType elementType, int damage) => health -= damage;

        public void TakeDamage(ElementType element, int damage)
        {
            health -= Element.TakeDamage(element, damage);
            TakeDamageInternal(element, damage);
        }

        public void ApplyHeal(int amount) => ApplyHealInternal(amount);

        protected virtual void ApplyHealInternal(int amount) => health += amount;

        public void AddEnhance(Enhance enhance) => _enhances.Add(enhance);

        private void OnDestroy()
        {
            _gameStateController.OnStateExited -= ExecuteEnhances;
            _enhances = null;
        }
    }
}