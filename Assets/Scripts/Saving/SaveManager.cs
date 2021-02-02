using Core;
using Saving.Entities;
using Saving.Serialization;
using UnityEngine;

namespace Saving
{
    public class SaveManager : MonoBehaviour
    {
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitRoot;

        private void OnEnable()
        {
            GameEvents.Instance.SaveGame += SaveGame;
            GameEvents.Instance.LoadGame += LoadGame;
        }

        private void SaveGame()
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

        private void LoadGame()
        {
            SaveData.Current = (SaveData) SerializationManager.Load("save");

            foreach (var unitData in SaveData.Current.Units)
            {
                var unit = Instantiate(_unitPrefab, _unitRoot);

                var unitHandler = unit.GetComponent<UnitHandler>();

                unitHandler.SetUnitData(unitData);
                unitHandler.transform.position = unitData.Position;
                unitHandler.transform.rotation = unitData.Rotation;
            }
        }
        
        private void OnDisable()
        {
            GameEvents.Instance.SaveGame -= SaveGame;
            GameEvents.Instance.LoadGame -= LoadGame;
        }
    }
}