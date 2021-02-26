using Units.Selectors;
using Units.Services;
using Units.Units;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class UnitsInstaller : MonoInstaller
    {
        [Header("Selection")] 
        [SerializeField] private SelectingInput _selectingInput;

        [Header("Selector (projection by default)")]
        [SerializeField] private bool _usePhysics3DSelector;
        
        [SerializeField] private RectTransform _selectionRect;
        [SerializeField] private Canvas _uiCanvas;
        
        [Header("Targeting")]
        [SerializeField] private MovementCommand _movementCommand;
        
        [Header("Unit")] [SerializeField]
        private GameObject _unitFacadePrefab;
        
        public override void InstallBindings()
        {
            BindUnitSelectionSystem();
            BindUnitSelector();
            
            Container.BindInstance(_movementCommand);

            BindUnit();
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

        private void BindUnit()
        {
            Container.Bind<UnitFacade>().FromSubContainerResolve().ByMethod(InstallUnitFacade).AsSingle();
            
            Container.BindFactory<UnitFacade, UnitFacade.Factory>().FromSubContainerResolve()
                .ByNewContextPrefab(_unitFacadePrefab);

            Container.BindInterfacesTo<UnitGenerator>().AsSingle();
        }

        private void InstallUnitFacade(DiContainer subContainer)
        {
            subContainer.Bind<UnitFacade>().AsSingle();
        }
    }
}