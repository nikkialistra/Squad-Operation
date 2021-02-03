using Saving;
using Saving.Entities;
using Selecting;
using Selecting.Units;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Events
{
    public class SaveLoadEvent : MonoBehaviour
    {
        [SerializeField] private Button _saveButton;
        [SerializeField] private Button _loadButton;

        private SaveLoadManager _saveLoadManager;
        private UnitRepository _unitRepository;
        private PointObjectPool _pointObjectPool;
        
        [Inject]
        public void Construct(SaveLoadManager saveLoadManager, UnitRepository unitRepository, PointObjectPool pointObjectPool)
        {
            _saveLoadManager = saveLoadManager;
            _unitRepository = unitRepository;
            _pointObjectPool = pointObjectPool;
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