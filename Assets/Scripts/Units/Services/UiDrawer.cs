using UnityEngine;

namespace Units.Services
{
    public class UiDrawer
    {
        private readonly RectTransform _selectionRect;
        private readonly GameObject _selectionGameObject;
        private readonly Canvas _uiCanvas;

        public UiDrawer(RectTransform selectionRect, Canvas uiCanvas)
        {
            _selectionRect = selectionRect;
            _selectionGameObject = selectionRect.gameObject;
            _uiCanvas = uiCanvas;
        }

        public void Draw(Rect rect)
        {
            if (_selectionGameObject.activeSelf == false)
                _selectionGameObject.SetActive(true);
            
            _selectionRect.position = rect.center;
            _selectionRect.sizeDelta = rect.size / _uiCanvas.scaleFactor;
        }

        public void StopDrawing() => _selectionGameObject.SetActive(false);
    }
}