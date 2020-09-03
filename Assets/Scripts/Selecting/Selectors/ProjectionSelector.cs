using System;
using System.Collections.Generic;
using Selecting.Repositories;
using Units;
using UnityEngine;

namespace Selecting.Selectors
{
    public class ProjectionSelector : ISelector
    {
        private readonly IUnitRepository _unitRepository;
        private readonly Camera _camera;

        private IEnumerable<Unit> _gameObjects;

        ProjectionSelector(IUnitRepository unitRepository, Camera camera)
        {
            _unitRepository = unitRepository;
            _camera = camera;
        }

        public IEnumerable<ISelectable> SelectInScreenSpace(Rect rect)
        {
            _gameObjects = _unitRepository.GetObjects();
            
            if (_gameObjects == null)
                throw new NullReferenceException();
            
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.GetComponent<ISelectable>() != null)
                {
                    Vector3 screenPoint = _camera.WorldToScreenPoint(gameObject.transform.position);

                    if (rect.Contains(screenPoint))
                    {
                        yield return gameObject.GetComponent<ISelectable>();
                    }
                }
            }
        }
    }
}