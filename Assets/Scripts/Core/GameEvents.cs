using System;

namespace Core
{
    public class GameEvents
    {
        public event Action SaveGame;
        public event Action LoadGame;

        public void Load() => LoadGame?.Invoke();
        
        public void Save() => SaveGame?.Invoke();
        
        private static GameEvents _instance;

        public static GameEvents Instance
        {
            get { return _instance ??= new GameEvents(); }
        }
    }
}