using System.Collections.Generic;
using Selecting.Units;
using UnityEngine;

namespace Selecting
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