using UnityEngine;

namespace Selecting.Drawers
{
    public class UiDrawer : ISelectingAreaDrawer
    {
        private RectTransform _selectionRect;
        private GameObject _selectionGameObject;

        UiDrawer(RectTransform selectionRect)
        {
            _selectionRect = selectionRect;
            _selectionGameObject = selectionRect.gameObject;
        }

        public void Draw(Rect rect)
        {
            if (_selectionGameObject.activeSelf == false)
                _selectionGameObject.SetActive(true);
        
            _selectionRect.position = rect.center;
            _selectionRect.sizeDelta = rect.size;
        }

        public void StopDrawing()
        {
            _selectionGameObject.SetActive(false);
        }
    }
}