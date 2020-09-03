using System.Collections.Generic;
using Units;
using UnityEngine;

namespace Selecting.Repositories
{
    public interface IUnitRepository
    {
        IEnumerable<Unit> GetObjects();
    }
}