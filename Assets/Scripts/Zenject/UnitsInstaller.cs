using Units.Selectors;
using Units.Services;
using UnityEngine;

namespace Zenject
{
    public class UnitsInstaller : MonoInstaller
    {
        [Header("Selection")] 
        [SerializeField] private SelectingInput _selectingInput;
        [SerializeField] private UnitRepository _unitRepository;
        
        [Header("Selector (projection by default)")]
        [SerializeField] private bool _usePhysics3DSelector;
        
        [SerializeField] private RectTransform _selectionRect;
        [SerializeField] private Canvas _uiCanvas;
        
        [Header("Targeting")] 
        [SerializeField] private GameObject _template;
        
        [SerializeField] private PointObjectPool _pool;
        [SerializeField] private MovementCommand _movementCommand;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_unitRepository).AsSingle();
            
            BindUnitSelectionSystem();
            BindUnitSelector();
            
            BindTargetingSystem();
        }
        
        private void BindUnitSelectionSystem()
        {
            Container.BindInterfacesAndSelfTo<UnitSelection>().AsSingle().NonLazy();
            Container.BindInstance(_selectingInput);
            Container.Bind<UiDrawer>().AsSingle().WithArguments(_selectionRect, _uiCanvas);
        }

        private void BindUnitSelector()
        {
            if (_usePhysics3DSelector)
                Container.Bind<ISelector>().To<Physics3DSelector>().AsSingle();
            else
                Container.Bind<ISelector>().To<ProjectionSelector>().AsSingle();
        }
        
        private void BindTargetingSystem()
        {
            Container.BindInstance(_template).WhenInjectedInto<PointObjectPool>();
            Container.Bind<PointObjectPool>().FromInstance(_pool);
            Container.BindInstance(_movementCommand);
        }
    }
}