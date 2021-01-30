using System.Collections.Generic;
using Units;
using UnityEngine;

namespace Selecting.Selectors
{
    public interface ISelector
    {
        IEnumerable<ISelectable> SelectInScreenSpace(Rect rect);
    }
}