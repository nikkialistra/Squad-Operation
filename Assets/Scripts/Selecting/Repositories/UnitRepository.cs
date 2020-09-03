using System.Collections.Generic;
using Units;
using UnityEngine;

namespace Selecting.Repositories
{
    public class UnitRepository : MonoBehaviour, IUnitRepository
    {
        public IEnumerable<Unit> GetObjects()
        {
            return GameObject.FindObjectsOfType<Unit>();
        }
    }
}