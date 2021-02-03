using UnityEngine;

namespace Selecting.Units
{
    public interface ITargetable
    {
        bool TryAcceptPoint(GameObject point);
    }
}