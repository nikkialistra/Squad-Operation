using System.Collections.Generic;
using Selecting.Units;
using UnityEngine;

namespace Selecting.Selectors
{
    public interface ISelector
    {
        IEnumerable<ISelectable> SelectInScreenSpace(Rect rect);
    }
}