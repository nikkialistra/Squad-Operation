using Zenject;
using UnityEngine;
using Selecting;
using Selecting.Drawers;
using Selecting.SelectingInputs;
using Selecting.Selectors;

namespace Zenject
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private Object _unitSelection;
        
        [SerializeField] private RectTransform _selectionRect;
        
        public override void InstallBindings()
        {
            Container.Bind<UnitSelection>().FromComponentInNewPrefab(_unitSelection).AsSingle().NonLazy();
            
            Container.Bind<ISelector>().To<ProjectionSelector>().FromComponentInNewPrefab(_unitSelection).AsSingle();
            Container.Bind<ISelectingInput>().To<PCSelectingInput>().FromComponentInNewPrefab(_unitSelection).AsSingle();
            Container.Bind<ISelectingAreaDrawer>().To<UiDrawer>().AsSingle().WithArguments(_selectionRect);
        }
    }
}