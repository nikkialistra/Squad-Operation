using System.Collections.Generic;
using Units;
using UnityEngine;

namespace Selecting.Repositories
{
    public class UnitRepository : MonoBehaviour, IUnitRepository
    {
        private IEnumerable<Unit> _gameObjects;
        
        public IEnumerable<Unit> GetObjects()
        {
            if (_gameObjects == null)
                _gameObjects = GameObject.FindObjectsOfType<Unit>();
            return _gameObjects;
        }

        public void ResetObjects()
        {
            _gameObjects = null;
        }
    }
}