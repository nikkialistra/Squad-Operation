using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

namespace Selecting.Units
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMeshAgent : MonoBehaviour, ITargetable
    {
        [SerializeField] private float _distanceToGroup;
        
        private NavMeshAgent _navMeshAgent;
        private bool destinationRandomized = false;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            RandomizeAgentDestinations();
        }

        public bool TryAcceptPoint(GameObject point)
        {
            destinationRandomized = false;
            return _navMeshAgent.SetDestination(point.transform.position);
        }

        private void RandomizeAgentDestinations()
        {
            if (_navMeshAgent.hasPath && destinationRandomized == false && _navMeshAgent.remainingDistance < _distanceToGroup)
            {
                _navMeshAgent.SetDestination(transform.position + Random.insideUnitSphere * _distanceToGroup);
                destinationRandomized = true;
            }
        }
    }
}