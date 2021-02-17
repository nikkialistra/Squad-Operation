using Saving;
using Saving.Entities;
using Units.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Events
{
    public class SaveLoadEvent : MonoBehaviour
    {
        private SaveLoadManager _saveLoadManager;
        private UnitRepository _unitRepository;
        private PointObjectPool _pointObjectPool;
        
        private Button _saveButton;
        private Button _loadButton;
        
        [Inject]
        public void Construct(SaveLoadManager saveLoadManager, UnitRepository unitRepository,
            PointObjectPool pointObjectPool, [Inject(Id = "save")] Button saveButton, [Inject(Id = "load")] Button loadButton)
        {
            _saveLoadManager = saveLoadManager;
            _unitRepository = unitRepository;
            _pointObjectPool = pointObjectPool;

            _saveButton = saveButton;
            _loadButton = loadButton;
        }

        private void OnEnable()
        {
            _saveButton.onClick.AddListener(Save);
            _loadButton.onClick.AddListener(Load);
        }
        
        private void OnDisable()
        {
            _saveButton.onClick.RemoveListener(Save);
            _loadButton.onClick.RemoveListener(Load);
        }

        private void Save()
        {
            _saveLoadManager.SaveGame();
        }
        
        private void Load()
        {
            foreach (var unitHandler in FindObjectsOfType<UnitHandler>())
            {
                unitHandler.DestroySelf();
            }
            
            _pointObjectPool.OffAll();
            
            _unitRepository.ResetObjects();
            _saveLoadManager.LoadGame();
        }
    }
}