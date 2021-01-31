using System.Linq;
using Controls;
using Selecting;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Units
{
    public class MovementCommand : MonoBehaviour
    {
        private PointObjectPool _pool;
        private UnitSelection _unitSelection;
        
        private Camera _camera;
        
        private Control _control;
        
        [Inject]
        public void Construct(Camera camera, UnitSelection unitSelection, PointObjectPool pool)
        {
            _camera = camera;
            _unitSelection = unitSelection;
            _pool = pool;
        }

        private void Awake()
        {
            _control = new Control();
        }
        
        private void OnEnable()
        {
            _control.Enable();
            _control.Targeting.SetTarget.started += SetTarget;
        }

        private void SetTarget(InputAction.CallbackContext context)
        {
            if (!_unitSelection.Selected.Any())
                return;

            Vector3? worldPoint = TryGetWorldPointUnderMouse();

            if (worldPoint.HasValue)
            {
                GameObject targetPoint = _pool.PlaceTo(worldPoint.Value);
                MoveAllTo(targetPoint);
            }
        }

        private Vector3? TryGetWorldPointUnderMouse()
        {
            Vector2 mousePosition = _control.Targeting.Position.ReadValue<Vector2>();
            Ray rayIntoScene =
                _camera.ScreenPointToRay(new Vector3(mousePosition.x, mousePosition.y, _camera.nearClipPlane));

            if (Physics.Raycast(rayIntoScene, out RaycastHit hit))
                return hit.point;
            else
                return null;
        }
        
        private void MoveAllTo(GameObject point)
        {
            foreach (var unit in _unitSelection.Selected)
            {
                if (unit is ITargetable targetable)
                {
                    if (targetable.TryAcceptPoint(point))
                        _pool.Link(point, targetable);
                }
            }
        }
        
        private void OnDisable()
        {
            _control.Disable();
            _control.Targeting.SetTarget.started -= SetTarget;
        }
    }
}