using UnityEngine;

namespace Units.Units
{
    public class Unit : MonoBehaviour, ISelectable
    {
        [SerializeField] private GameObject _selectionIndicator;

        public GameObject GameObject => gameObject;

        public void OnSelect()
        {
            _selectionIndicator.SetActive(true);
        }

        public void OnDeselect()
        {
            _selectionIndicator.SetActive(false);
        }
    }
}