using System;
using System.Collections.Generic;
using System.Linq;
using Selecting.Repositories;
using Units;
using UnityEngine;
using Zenject;

namespace Selecting.Selectors
{
    public class Physics3DSelector : ISelector
    {
        private readonly IUnitRepository _unitRepository;
        private readonly Camera _camera;

        private IEnumerable<Unit> _gameObjects;

        Physics3DSelector(IUnitRepository unitRepository, Camera camera)
        {
            _unitRepository = unitRepository;
            _camera = camera;
        }

        public IEnumerable<ISelectable> SelectInScreenSpace(Rect rect)
        {
            _gameObjects = _unitRepository.GetObjects();
            
            if (_gameObjects == null)
                throw new NullReferenceException();
            
            Vector3[] corners = {
                GetWorldPosition(rect.min),
                GetWorldPosition(rect.min + new Vector2(rect.width, 0)),
                GetWorldPosition(rect.min + new Vector2(0, rect.height)),
                GetWorldPosition(rect.max)
            };
            
            foreach (var gameObject in _gameObjects)
            {
                if (gameObject.GetComponent<ISelectable>() != null)
                {
                    if (PositionBetween4CornersInXZProjection(gameObject.transform.position, corners))
                    {
                        yield return gameObject.GetComponent<ISelectable>();
                    }
                }
            }
        }

        private Vector3 GetWorldPosition(Vector2 screenPoint)
        {
            var ray = _camera.ScreenPointToRay(new Vector2(screenPoint.x, screenPoint.y));

            if (Physics.Raycast(ray, out RaycastHit hit))
                return hit.point;
            
            throw new InvalidOperationException();
        }
        
        private bool PositionBetween4CornersInXZProjection(Vector3 position, Vector3[] corners)
        {
            if (corners.Length != 4)
                throw new InvalidOperationException();

            // 0-size rect don't have objects and leads to incorrect computations
            if (corners[0] == corners[1])
                return false;

            Vector2 vector01 = new Vector2(corners[1].x - corners[0].x, corners[1].z - corners[0].z);
            Vector2 vector0P = new Vector2(position.x - corners[0].x, position.z - corners[0].z);
            Vector2 vector12 = new Vector2(corners[2].x - corners[1].x, corners[2].z - corners[1].z);
            Vector2 vector1P = new Vector2(position.x - corners[1].x, position.z - corners[1].z);
            
            float dot01x0P = Vector2.Dot(vector01, vector0P);
            float dot01x01 = Vector2.Dot(vector01, vector01);
            float dot12x1P = Vector2.Dot(vector12, vector1P);
            float dot12x12 = Vector2.Dot(vector12, vector12);
            
            return 0 <= dot01x0P && dot01x0P <= dot01x01 && 0 <= dot12x1P && dot12x1P <= dot12x12;
        }
    }
}