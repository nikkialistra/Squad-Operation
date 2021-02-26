using Infrastructure.Events;
using Infrastructure.Signals;
using Saving;
using Saving.Entities;
using Units.Services;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class SaveLoadInstaller : MonoInstaller
    {
        [Header("Base")]
        [SerializeField] private SaveLoadManager _saveLoadManager;
        [SerializeField] private SaveEvent _saveEvent;
        [SerializeField] private LoadEvent _loadEvent;
        
        [Header("Unit Handling")]
        [SerializeField] private UnitsHandler _unitsHandler;

        [Header("Unit")] 
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitRoot;

        public override void InstallBindings()
        {
            BindSignals();

            Container.BindInstance(_saveLoadManager).AsSingle();
            
            BindUnitHandling();

            BindUnits();
        }

        private void BindSignals()
        {
            Container.BindInstance(_saveEvent).AsSingle();
            Container.BindInstance(_loadEvent).AsSingle();

            BindSaveSignal();
            BindLoadSignal();
        }

        private void BindUnitHandling()
        {
            Container.BindInstance(_unitsHandler).AsSingle();
        }

        private void BindLoadSignal()
        {
            Container.BindSignal<LoadSignal>().ToMethod<UnitsHandler>(x => x.DestroyUnits).FromResolve();
            Container.BindSignal<LoadSignal>().ToMethod<PointObjectPool>(x => x.OffAll).FromResolve();
            Container.BindSignal<LoadSignal>().ToMethod<UnitRepository>(x => x.ResetObjects).FromResolve();
            Container.BindSignal<LoadSignal>().ToMethod<SaveLoadManager>(x => x.LoadGame).FromResolve();
        }

        private void BindSaveSignal()
        {
            Container.BindSignal<SaveSignal>().ToMethod<SaveLoadManager>(x => x.SaveGame).FromResolve();
        }

        private void BindUnits()
        {
            Container.BindInstance(_unitPrefab).AsSingle();
            Container.BindInstance(_unitRoot).AsSingle();
        }
    }
}