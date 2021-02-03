using System;
using System.Collections.Generic;
using Saving.Entities;

namespace Saving
{
    [Serializable]
    public class SaveData
    {
        private static SaveData _current;
        
        private SaveData() { }

        public static SaveData Current
        {
            get { return _current ??= new SaveData(); }
            set => _current = value;
        }

        public IList<UnitData> Units = new List<UnitData>();
    }
}