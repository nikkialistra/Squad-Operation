using UnityEngine;
using Zenject;

namespace Units.Units
{
    public class Unit : MonoBehaviour, ISelectable
    {
        private GameObject _selectionIndicator;

        [Inject]
        public void Construct(GameObject selectionIndicator) => _selectionIndicator = selectionIndicator;

        public GameObject GameObject => gameObject;

        public void OnSelect() => _selectionIndicator.SetActive(true);

        public void OnDeselect() => _selectionIndicator.SetActive(false);
    }
}