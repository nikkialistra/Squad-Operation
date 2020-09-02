using UnityEngine;
using UnityEngine.AI;

namespace Units
{
    public class Unit : MonoBehaviour, ISelectable, ITargetable
    {
        [SerializeField] private Renderer _renderer;
        [SerializeField] private NavMeshAgent _navMeshAgent;

        [SerializeField] private Material _selected;
        [SerializeField] private Material _deselected;
        
        public void OnSelect()
        {
            _renderer.material = _selected;
        }

        public void OnDeselect()
        {
            _renderer.material = _deselected;
        }

        public bool TryAcceptPoint(GameObject point)
        {
            return _navMeshAgent.SetDestination(point.transform.position);
        }
    }
}