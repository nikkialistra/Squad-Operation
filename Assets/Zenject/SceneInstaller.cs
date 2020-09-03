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
        [SerializeField] private Camera _camera;
        
        [SerializeField] private Object _unitRepository;
        [SerializeField] private Object _unitSelection;

        [SerializeField] private RectTransform _selectionRect;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UnitSelection>().AsSingle().NonLazy();
            
            Container.Bind<ISelector>().To<ProjectionSelector>().AsSingle().WithArguments(_camera);
            Container.Bind<IUnitRepository>().To<UnitRepository>().FromComponentInNewPrefab(_unitRepository).AsSingle();
            
            Container.Bind<ISelectingInput>().To<PCSelectingInput>().FromComponentInNewPrefab(_unitSelection).AsSingle();
            Container.Bind<ISelectingAreaDrawer>().To<UiDrawer>().AsSingle().WithArguments(_selectionRect);
        }
    }
}