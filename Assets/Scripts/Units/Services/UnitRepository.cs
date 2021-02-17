using System.Collections.Generic;
using Units.Units;
using UnityEngine;

namespace Units.Services
{
    public class UnitRepository : MonoBehaviour
    {
        private IEnumerable<Unit> _gameObjects;

        public IEnumerable<Unit> GetObjects()
        {
            return _gameObjects ??= FindObjectsOfType<Unit>();
        }

        public void ResetObjects()
        {
            _gameObjects = null;
        }
    }
}