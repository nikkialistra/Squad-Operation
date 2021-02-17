using Events;
using Saving;
using Units.Services;
using UnityEngine;
using UnityEngine.UI;

namespace Zenject
{
    public class SaveLoadInstaller : MonoInstaller
    {
        [Header("Base")]
        [SerializeField] private SaveLoadManager _saveLoadManager;
        [SerializeField] private SaveLoadEvent _saveLoadEvent;
        
        [Header("Repository")]
        [SerializeField] private UnitRepository _unitRepository;
        [SerializeField] private PointObjectPool _pool;
        
        [Header("Units")]
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitRoot;
        
        [Header("Buttons")]
        [SerializeField] private Button _saveButton;
        [SerializeField] private Button _loadButton;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_saveLoadManager).AsSingle();
            
            Container.BindInstance(_unitRepository).AsSingle();
            Container.Bind<PointObjectPool>().FromInstance(_pool);
            
            Container.BindInstance(_saveLoadEvent).AsSingle();

            BindUnits();

            BindButtons();
        }

        private void BindUnits()
        {
            Container.BindInstance(_unitPrefab).AsSingle();
            Container.BindInstance(_unitRoot).AsSingle();
        }

        private void BindButtons()
        {
            Container.BindInstance(_saveButton).WithId("save");
            Container.BindInstance(_loadButton).WithId("load");
        }
    }
}