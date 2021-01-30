using Saving;
using UnityEngine;
using Selecting;
using Selecting.Repositories;
using Selecting.Selectors;
using Services;

namespace Zenject
{
    public class SceneInstaller : MonoInstaller
    {
        [Header("Services")] 
        [SerializeField] private UnitRepository _unitRepository;
        [SerializeField] private SelectingInput _selectingInput;

        [SerializeField] private SaveManager _saveManager;
        [SerializeField] private GameEvents _gameEvents;

        [Header("Selector (projection by default)")] 
        [SerializeField] private bool _usePhysics3DSelector;
        
        [Header("Other")]
        [SerializeField] private Camera _camera;
        [SerializeField] private RectTransform _selectionRect;
        [SerializeField] private Canvas _uiCanvas;

        public override void InstallBindings()
        {
            Container.BindInstance(_camera).AsSingle();
            
            Container.BindInterfacesTo<UnitSelection>().AsSingle().NonLazy();

            if (_usePhysics3DSelector)
                Container.Bind<ISelector>().To<Physics3DSelector>().AsSingle();
            else
                Container.Bind<ISelector>().To<ProjectionSelector>().AsSingle();

            Container.Bind<IUnitRepository>().FromInstance(_unitRepository);
            Container.BindInstance(_selectingInput);
            
            Container.Bind<UiDrawer>().AsSingle().WithArguments(_selectionRect, _uiCanvas);
        }
    }
}