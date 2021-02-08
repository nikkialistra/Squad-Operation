using Saving.Entities;
using Saving.Serialization;
using UnityEngine;

namespace Saving
{
    public class SaveLoadManager : MonoBehaviour
    {
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitRoot;

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

                var unitHandler = unit.GetComponent<UnitHandler>();

                unitHandler.SetUnitData(unitData);
            }
        }
    }
}