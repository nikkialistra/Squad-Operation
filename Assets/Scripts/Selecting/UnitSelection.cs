using System;
using System.Collections.Generic;
using System.Linq;
using Selecting.Drawers;
using Selecting.SelectingInputs;
using Selecting.Selectors;
using Units;
using UnityEngine;
using Zenject;

namespace Selecting
{
    public class UnitSelection : MonoBehaviour
    {
        [SerializeField] private ISelector _selector;
        [SerializeField] private ISelectingInput _selectingInput;
        [SerializeField] private ISelectingAreaDrawer _selectingAreaDrawer;
        
        public IEnumerable<ISelectable> Selected { get; private set; } = new ISelectable[0];
        
        [Inject]
        public void Construct(ISelector selector, ISelectingInput selectingInput, ISelectingAreaDrawer selectingAreaDrawer)
        {
            _selector = selector;
            _selectingInput = selectingInput;
            _selectingAreaDrawer = selectingAreaDrawer;
        }

        private void OnEnable()
        {
            _selectingInput.Selecting += OnSelecting;
            _selectingInput.SelectingEnded += OnSelectingEnded;
        }
        
        private void OnDisable()
        {
            _selectingInput.Selecting -= OnSelecting;
            _selectingInput.SelectingEnded -= OnSelectingEnded;
        }

        private void ClearSelected()
        {
            Selected = Enumerable.Empty<ISelectable>();
        }
    

        private void OnSelecting(Rect rect)
        {
            _selectingAreaDrawer.Draw(rect);
        }

        private void OnSelectingEnded(Rect rect)
        {
            var newSelected = _selector.SelectInScreenSpace(rect);

            foreach (var willDeselect in Selected.Except(newSelected))
            {
                willDeselect.OnDeselect();
            }

            foreach (var selected in newSelected)
            {
                selected.OnSelect();
            }

            Selected = newSelected;

            _selectingAreaDrawer.StopDrawing();
        }
    }
}