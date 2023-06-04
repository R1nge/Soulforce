using System.Collections.Generic;
using Cards.Behaviours;
using Units;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Card
{
    public class CardDragController : MonoBehaviour
    {
        private Vector3 _centerOffset;
        private readonly List<RaycastResult> _results = new();
        private Transform _draggedObject;
        private CardBehaviour _selectedCard;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SetDraggedObject();
            }

            if (Input.GetMouseButton(0))
            {
                Drag();
            }

            if (Input.GetMouseButtonUp(0))
            {
                TryApplyCard();
                ResetDraggedObject();
            }
        }

        private void SetDraggedObject()
        {
            EventSystem.current.RaycastAll(GetCursorPosition(), _results);
            if (_results.Count == 0)
            {
                Debug.LogError("No object found", this);
                return;
            }

            _draggedObject = _results[0].gameObject.transform.parent;
            if (_draggedObject.TryGetComponent(out CardBehaviour cardBehaviour))
            {
                _selectedCard = cardBehaviour;
            }
        }

        private void Drag()
        {
            if (!HasDraggedObject()) return;

            EventSystem.current.RaycastAll(GetCursorPosition(), _results);
            _draggedObject.position = new(GetCursorPosition().position.x, GetCursorPosition().position.y, transform.position.z);
        }

        private void ResetDraggedObject()
        {
            _draggedObject = null;
            _selectedCard = null;
        }
        
        private void TryApplyCard()
        {
            if (!HasDraggedObject()) return;
            _selectedCard.TryUseCard(FindObjectOfType<EnemyUnit>());
        }

        private PointerEventData GetCursorPosition()
        {
            return new(EventSystem.current)
            {
                position = Input.mousePosition
            };
        }

        private bool HasDraggedObject() => _draggedObject != null;
    }
}