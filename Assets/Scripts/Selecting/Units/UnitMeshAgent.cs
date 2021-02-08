using System;
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
            Debug.Log(11);
            return _navMeshAgent.SetDestination(point.transform.position);
        }

        private void RandomizeAgentDestinations()
        {
            if (_navMeshAgent.hasPath && _navMeshAgent.remainingDistance < _distanceToGroup)
                _navMeshAgent.destination += Random.insideUnitSphere * _distanceToGroup;
        }
    }
}