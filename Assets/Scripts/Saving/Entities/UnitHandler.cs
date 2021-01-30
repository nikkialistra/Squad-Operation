using System;
using Services;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Saving.Entities
{
    public class UnitHandler : MonoBehaviour
    {
        [SerializeField] private UnitType _unitType;
        
        private UnitData _unitData;

        private void Start()
        {
            if (string.IsNullOrEmpty(_unitData.Id))
            {
                _unitData.Id = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString() +
                               Random.Range(0, int.MaxValue);

                _unitData.Type = _unitType;
            }

            GameEvents.Instance.LoadGame += DestroySelf;
        }

        public void DestroySelf()
        {
            GameEvents.Instance.LoadGame -= DestroySelf;
            Destroy(gameObject);
        }

        private void Update()
        {
            _unitData.Position = transform.position;
            _unitData.Rotation = transform.rotation;
        }
        
        public UnitData GetUnitData()
        {
            return _unitData;
        }

        public void SetUnitData(UnitData unitData)
        {
            _unitData = unitData;
        }
    }
}