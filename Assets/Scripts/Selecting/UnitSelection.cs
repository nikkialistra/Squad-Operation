using System.Collections.Generic;
using System.Linq;
using Selecting.Selectors;
using Units;
using UnityEngine;
using Zenject;

namespace Selecting
{
    public class UnitSelection : IInitializable
    {
        private ISelector _selector;
        private SelectingInput _selectingInput;
        private UiDrawer _selectingAreaDrawer;
        
        public IEnumerable<ISelectable> Selected { get; private set; } = new ISelectable[0];
        
        [Inject]
        public void Construct(ISelector selector, SelectingInput selectingInput, UiDrawer selectingAreaDrawer)
        {
            _selector = selector;
            _selectingInput = selectingInput;
            _selectingAreaDrawer = selectingAreaDrawer;
        }
        
        public void Initialize()
        {
            _selectingInput.Selecting += OnSelecting;
            _selectingInput.SelectingEnded += OnSelectingEnded;
        }

        private void OnSelecting(Rect rect)
        {
            _selectingAreaDrawer.Draw(rect);
        }

        public void OnSelectingEnded(Rect rect)
        {
            var newSelected = Enumerable.Empty<ISelectable>();
            if (rect.size != Vector2.zero)
                newSelected = _selector.SelectInScreenSpace(rect);

            var newSelectedArray = newSelected as ISelectable[] ?? newSelected.ToArray();
            foreach (var willDeselect in Selected.Except(newSelectedArray))
            {
                willDeselect.OnDeselect();
            }

            foreach (var selected in newSelectedArray)
            {
                selected.OnSelect();
            }

            Selected = newSelectedArray;

            _selectingAreaDrawer.StopDrawing();
        }
    }
}