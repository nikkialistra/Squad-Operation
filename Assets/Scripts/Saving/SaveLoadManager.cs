using Saving.Entities;
using Saving.Serialization;
using UnityEngine;
using Zenject;

namespace Saving
{
    public class SaveLoadManager : MonoBehaviour
    {
        private GameObject _unitPrefab;
        private Transform _unitRoot;
        
        [Inject]
        public void Construct(GameObject unitPrefab, Transform unitRoot)
        {
            _unitPrefab = unitPrefab;
            _unitRoot = unitRoot;
        }

        public void SaveGame()
        {
            var saveData = SaveData.Current;
       
            saveData.Units.Clear();
            
            foreach (var unitHandler in FindObjectsOfType<UnitHandler>())
            {
                var unitData = unitHandler.GetUnitData();
                saveData.Units.Add(unitData);
            }

            SerializationManager.Save("save", saveData);
        }

        public void LoadGame()
        {
            SaveData.Current = (SaveData) SerializationManager.Load("save");

            foreach (var unitData in SaveData.Current.Units)
            {
                var unit = Instantiate(_unitPrefab, _unitRoot);

                var unitHandler = unit.GetComponentInChildren<UnitHandler>();

                unitHandler.SetUnitData(unitData);
            }
        }
    }
}