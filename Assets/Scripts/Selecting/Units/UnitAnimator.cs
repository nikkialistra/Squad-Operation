using System;
using UnityEngine;
using UnityEngine.AI;

namespace Selecting.Units
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitAnimator : MonoBehaviour
    {
        private NavMeshAgent _navMeshAgent;
        
        private Animator _animator;
        private readonly UnitAnimator _unitAnimator;
        
        private readonly int _velocity = Animator.StringToHash("velocity");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            SetAnimatorVelocity();
        }

        private void SetAnimatorVelocity()
        {
            var velocity = _navMeshAgent.velocity.magnitude;
           _animator.SetFloat(_velocity, velocity);
        }
    }
}