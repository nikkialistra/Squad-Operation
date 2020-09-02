using System.Collections.Generic;
using Units;
using UnityEngine;

namespace Selecting.Selectors
{
    public class ProjectionSelector : MonoBehaviour, ISelector
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private string _objectTag = "Selectable";

        private List<GameObject> _gameObjects;

        private void Start()
        {
            GetObjectsByTag();
        }

        public void GetObjectsByTag()
        {
            _gameObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag(_objectTag));
        }

        public IEnumerable<ISelectable> SelectInScreenSpace(Rect rect)
        {
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.GetComponent<ISelectable>() != null)
                {
                    Vector3 screenPoint = _camera.WorldToScreenPoint(gameObject.transform.position);

                    if (rect.Contains(screenPoint))
                    {
                        yield return gameObject.GetComponent<ISelectable>();
                    }
                }
            }
        }
    }
}