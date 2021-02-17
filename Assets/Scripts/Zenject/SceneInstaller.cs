using UnityEngine;

namespace Zenject
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private Camera _camera;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_camera).AsSingle();
        }
    }
}