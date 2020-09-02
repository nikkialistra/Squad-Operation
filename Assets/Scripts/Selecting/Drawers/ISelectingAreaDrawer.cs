using UnityEngine;

namespace Selecting.Drawers
{
    public interface ISelectingAreaDrawer
    {
        void Draw(Rect rect);
        void StopDrawing();
    }
}