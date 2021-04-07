using UnityEngine;
using Zenject;

namespace Units.Units
{
    public class UnitFacade : MonoBehaviour
    {
        public class Factory : PlaceholderFactory<UnitFacade>
        {
        }
    }
}
