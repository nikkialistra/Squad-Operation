using System.Collections.Generic;
using Units;

namespace Selecting.Repositories
{
    public interface IUnitRepository
    {
        IEnumerable<Unit> GetObjects();
        void ResetObjects();
    }
}