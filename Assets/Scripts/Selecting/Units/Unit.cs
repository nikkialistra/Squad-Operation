using UnityEngine;

namespace Selecting.Units
{
    public class Unit : MonoBehaviour, ISelectable
    {
        [SerializeField] private GameObject _selectionIndicator;

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