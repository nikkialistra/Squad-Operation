using UnityEngine;
using UnityEngine.AI;

namespace Units
{
    public class Unit : MonoBehaviour, ISelectable, ITargetable
    {
        [SerializeField] private GameObject _selectionIndicator;
        
        [SerializeField] private NavMeshAgent _navMeshAgent;
        
        public void OnSelect()
        {
            _selectionIndicator.SetActive(true);
        }

        public void OnDeselect()
        {
            _selectionIndicator.SetActive(false);
        }

        public bool TryAcceptPoint(GameObject point)
        {
            return _navMeshAgent.SetDestination(point.transform.position);
        }
    }
}