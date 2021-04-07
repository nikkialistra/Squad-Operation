using UnityEngine;

namespace Saving.Entities
{
    public class UnitsHandler : MonoBehaviour
    {
        public void DestroyUnits()
        {
            foreach (var unitHandler in FindObjectsOfType<UnitHandler>()) 
                unitHandler.DestroySelf();
        }
    }
}