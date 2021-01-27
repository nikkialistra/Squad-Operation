using UnityEngine;
using Selecting;
using Selecting.Drawers;
using Selecting.Repositories;
using Selecting.SelectingInputs;
using Selecting.Selectors;

namespace Zenject
{
    public class SceneInstaller : MonoInstaller
    {
        [Header("Services")] 
        [SerializeField] private Object _unitRepository;
        [SerializeField] private Object _unitSelection;

        [Header("Selector (projection by default)")] 
        [SerializeField] private bool _usePhysics3DSelector;
        
        [Header("Other")]
        [SerializeField] private Camera _camera;
        [SerializeField] private RectTransform _selectionRect;
        [SerializeField] private Canvas _uiCanvas;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UnitSelection>().AsSingle().NonLazy();

            Container.BindInstance(_camera).AsSingle();

            if (_usePhysics3DSelector)
                Container.Bind<ISelector>().To<Physics3DSelector>().AsSingle().WithArguments(_camera);
            else
                Container.Bind<ISelector>().To<ProjectionSelector>().AsSingle().WithArguments(_camera);
            
            Container.Bind<IUnitRepository>().To<UnitRepository>().FromComponentInNewPrefab(_unitRepository).AsSingle();
            
            Container.Bind<ISelectingInput>().To<SelectingInput>().FromComponentInNewPrefab(_unitSelection).AsSingle();
            Container.Bind<ISelectingAreaDrawer>().To<UiDrawer>().AsSingle().WithArguments(_selectionRect, _uiCanvas);
        }
    }
}