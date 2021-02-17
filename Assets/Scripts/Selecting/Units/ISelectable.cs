using UnityEngine;

namespace Selecting.Units
{
    public interface ISelectable
    {
        GameObject GameObject { get; }
        void OnSelect();
        void OnDeselect();
    }
}