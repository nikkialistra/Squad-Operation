using System;
using UnityEngine;

namespace Selecting.SelectingInputs
{
    public class PCSelectingInput : MonoBehaviour, ISelectingInput
    {
        public event Action<Rect> Selecting;
        public event Action<Rect> SelectingEnded;

        private Vector2? _startPoint;

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftControl) == false)
            {
                if (_startPoint == null)
                {
                    if (Input.GetMouseButtonDown(0))
                        StartArea(GetScreenSpaceMousePosition());
                }
                else
                {
                    if (Input.GetMouseButton(0))
                        UpdateArea(GetScreenSpaceMousePosition());
                    if (Input.GetMouseButtonUp(0))
                        EndArea(GetScreenSpaceMousePosition());
                }
            }
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

        private Vector2 GetScreenSpaceMousePosition()
        {
            return new Vector2(Input.mousePosition.x, Input.mousePosition.y);
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