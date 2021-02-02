using System.Collections.Generic;
using Core;
using Units;
using UnityEngine;

namespace Selecting.Repositories
{
    public class UnitRepository : MonoBehaviour, IUnitRepository
    {
        private IEnumerable<Unit> _gameObjects;
        
        private void OnEnable()
        {
            GameEvents.Instance.LoadGame += ResetObjects;
        }
        
        public IEnumerable<Unit> GetObjects()
        {
            return _gameObjects ??= FindObjectsOfType<Unit>();
        }

        public void ResetObjects()
        {
            _gameObjects = null;
        }
        
        private void OnDisable()
        {
            GameEvents.Instance.LoadGame += ResetObjects;
        }
    }
}