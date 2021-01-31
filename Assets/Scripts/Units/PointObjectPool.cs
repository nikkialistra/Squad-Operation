﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

namespace Units
{
    public class PointObjectPool : MonoBehaviour
    {
        private GameObject _template;
        
        private Dictionary<GameObject, List<ITargetable>> _links = new Dictionary<GameObject, List<ITargetable>>();
        
        [Inject]
        public void Construct(GameObject template)
        {
            _template = template;
        }
        
        public GameObject PlaceTo(Vector3 coordinate)
        {
            GameObject target = GetFromPullOrCreate();

            target.transform.position = coordinate;
            target.gameObject.SetActive(true);

            return target;
        }

        private GameObject GetFromPullOrCreate()
        {
            foreach (var target in _links.Keys)
            {
                if (!_links[target].Any())
                    return target;
            }

            return CreateNew();    
        }

        private GameObject CreateNew()
        {
            var target = Instantiate(_template, Vector3.zero, Quaternion.identity);
            target.SetActive(false);
            
            _links.Add(target, new List<ITargetable>());

            return target;
        }

        public void Link(GameObject point, ITargetable from)
        {
            if (_links.ContainsKey(point) == false)
                throw new InvalidOperationException();

            _links.Values
                .FirstOrDefault(sources => sources.Contains(from))
                ?.Remove(from);
            
            _links[point].Add(from);

            OffAllWithoutLinks();
        }

        private void OffAllWithoutLinks()
        {
            foreach (var point in _links.Keys)
            {
                if (!_links[point].Any())
                    point.gameObject.SetActive(false);
            }
        }
    }
}