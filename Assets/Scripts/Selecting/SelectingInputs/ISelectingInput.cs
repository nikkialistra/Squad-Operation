using System;
using UnityEngine;

namespace Selecting.SelectingInputs
{
    public interface ISelectingInput
    {
        event Action<Rect> Selecting;
        event Action<Rect> SelectingEnded;
    }
}