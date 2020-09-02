using UnityEngine;

namespace Units
{
    public interface ITargetable
    {
        bool TryAcceptPoint(GameObject point);
    }
}