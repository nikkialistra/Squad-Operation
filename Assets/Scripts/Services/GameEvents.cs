using System;
using UnityEngine;

namespace Services
{
    public class GameEvents : MonoBehaviour
    {
        public event Action SaveGame;
        public event Action LoadGame;

        public void Load() => LoadGame?.Invoke();
        
        public void Save() => SaveGame?.Invoke();
        
        private static GameEvents _instance;

        public static GameEvents Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<GameEvents>();
                    if (_instance == null)
                        _instance = new GameObject("Instance of " + typeof(GameEvents)).AddComponent<GameEvents>();
                }

                return _instance;
            }
        }

        private void Awake () {
            if (_instance != null)
                Destroy(this);
            
            DontDestroyOnLoad(this);
        }
    }
}