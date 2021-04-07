using Units.Units;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class UnitInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _selectionIndicator;
        [SerializeField] private float _distanceToGroup;

        [SerializeField] private UnitFacade _unitFacade;
        
        
        public override void InstallBindings()
        {
            Container.BindInstance(_selectionIndicator).WhenInjectedInto<Unit>();
            Container.BindInstance(_distanceToGroup).WhenInjectedInto<UnitMeshAgent>();
        }
    }
}