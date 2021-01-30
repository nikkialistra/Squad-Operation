using Saving.Entities;
using Selecting.Repositories;
using Serialization;
using Services;
using UnityEngine;
using Zenject;

namespace Saving
{
    public class SaveManager : MonoBehaviour
    {
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitRoot;
        
        private IUnitRepository _unitRepository;

        [Inject]
        public void Construct(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        private void Start()
        {
            GameEvents.Instance.SaveGame += SaveGame;
            GameEvents.Instance.LoadGame += LoadGame;
        }

        public void SaveGame()
        {
            SaveData saveData = SaveData.Current;
       
            saveData.Units.Clear();
            
            foreach (var unitHandler in FindObjectsOfType<UnitHandler>())
            {
                UnitData unitData = unitHandler.GetUnitData();
                saveData.Units.Add(unitData);
            }

            SerializationManager.Save("save", saveData);
        }
        
        public void LoadGame()
        {
            SaveData.Current = (SaveData) SerializationManager.Load("save");
            
            _unitRepository.ResetObjects();

            foreach (var unitData in SaveData.Current.Units)
            {
                GameObject gameObject = Instantiate(_unitPrefab, _unitRoot);

                UnitHandler unitHandler = gameObject.GetComponent<UnitHandler>();

                unitHandler.SetUnitData(unitData);
                unitHandler.transform.position = unitData.Position;
                unitHandler.transform.rotation = unitData.Rotation;
            }
        }
    }
}