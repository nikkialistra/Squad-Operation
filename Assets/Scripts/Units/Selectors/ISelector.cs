using System.Collections.Generic;
using Units.Units;
using UnityEngine;

namespace Units.Selectors
{
    public interface ISelector
    {
        IEnumerable<ISelectable> SelectInScreenSpace(Rect rect);
    }
}