using System;
using UnityEngine;

namespace Saving.Entities
{
    [Serializable]
    public enum UnitType
    {
    Regular,    
        Other
    }
    
    [Serializable]
    public struct UnitData
    {
        public string Id;
        
        public UnitType Type;
        
        public Vector3 Position;
        public Quaternion Rotation;
    }
}