using System;
using Controls;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Selecting.SelectingInputs
{
    public class SelectingInput : MonoBehaviour, ISelectingInput
    {
        public event Action<Rect> Selecting;
        public event Action<Rect> SelectingEnded;

        private Control _control;

        private Vector2? _startPoint;

        private void Awake()
        {
            _control = new Control();

            MakeControlBindings();
        }

        private void MakeControlBindings()
        {
            _control.Selection.Start.performed += SelectionStarted;
            _control.Selection.Finish.performed += SelectionEnded;
        }
        
        private void SelectionStarted(InputAction.CallbackContext context)
        {
            StartArea(_control.Selection.Position.ReadValue<Vector2>());
        }
        
        private void SelectionEnded(InputAction.CallbackContext context)
        {
            EndArea(_control.Selection.Position.ReadValue<Vector2>());
        }

        private void OnEnable()
        {
            _control.Enable();
        }

        private void OnDisable()
        {
            _control.Disable();
        }

        private void Update()
        {
            if (_startPoint != null)
                UpdateArea(_control.Selection.Position.ReadValue<Vector2>());
        }

        private void StartArea(Vector2 screenPoint)
        {
            _startPoint = screenPoint;
        }

        private void UpdateArea(Vector2 screenPoint)
        {
            if (_startPoint == null)
                throw new InvalidOperationException();

            Selecting?.Invoke(GetRect(_startPoint.Value, screenPoint));
        }

        private void EndArea(Vector2 screenPoint)
        {
            if (_startPoint == null)
                throw new InvalidOperationException();

            SelectingEnded?.Invoke(GetRect(_startPoint.Value, screenPoint));
            
            _startPoint = null;
        }
        
        private Rect GetRect(Vector2 a, Vector2 b)
        {
            Vector2 minCorner = new Vector2(a.x < b.x ? a.x : b.x, a.y < b.y ? a.y : b.y);
            Vector2 maxCorner = new Vector2(a.x > b.x ? a.x : b.x, a.y > b.y ? a.y : b.y);
            Vector2 size = new Vector2(maxCorner.x - minCorner.x, maxCorner.y - minCorner.y);
            
            return new Rect(minCorner, size);
        }
    }
}