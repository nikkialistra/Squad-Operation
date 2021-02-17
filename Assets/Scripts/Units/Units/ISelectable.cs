using UnityEngine;

namespace Units.Units
{
    public interface ISelectable
    {
        GameObject GameObject { get; }
        void OnSelect();
        void OnDeselect();
    }
}