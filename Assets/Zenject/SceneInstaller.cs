using Saving;
using UnityEngine;
using Selecting;
using Selecting.Repositories;
using Selecting.Selectors;
using Units;

namespace Zenject
{
    public class SceneInstaller : MonoInstaller
    {
        [Header("MonoServices")] 
        [SerializeField] private UnitRepository _unitRepository;
        [SerializeField] private SelectingInput _selectingInput;
        [SerializeField] private SaveManager _saveManager;
        

        [Header("Selector (projection by default)")] 
        [SerializeField] private bool _usePhysics3DSelector;
        
        [Header("Selection")]
        [SerializeField] private Camera _camera;
        [SerializeField] private RectTransform _selectionRect;
        [SerializeField] private Canvas _uiCanvas;
        
        [Header("Targeting")] 
        [SerializeField] private GameObject _template;
        
        [SerializeField] private PointObjectPool _pool;
        [SerializeField] private MovementCommand _movementCommand;

        public override void InstallBindings()
        {
            Container.BindInstance(_camera).AsSingle();
            
            Container.BindInterfacesAndSelfTo<UnitSelection>().AsSingle().NonLazy();

            if (_usePhysics3DSelector)
                Container.Bind<ISelector>().To<Physics3DSelector>().AsSingle();
            else
                Container.Bind<ISelector>().To<ProjectionSelector>().AsSingle();

            Container.Bind<IUnitRepository>().FromInstance(_unitRepository);
            Container.BindInstance(_selectingInput);
            
            Container.Bind<UiDrawer>().AsSingle().WithArguments(_selectionRect, _uiCanvas);

            Container.BindInstance(_saveManager);

            Container.BindInstance(_template).WhenInjectedInto<PointObjectPool>();
            Container.Bind<PointObjectPool>().FromInstance(_pool);
            Container.BindInstance(_movementCommand);
        }
    }
}