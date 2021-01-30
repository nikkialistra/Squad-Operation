using System;
using System.Collections.Generic;
using Saving.Entities;

namespace Saving
{
    [Serializable]
    public class SaveData
    {
        private static SaveData _current;
        public static SaveData Current
        {
            get
            {
                if (_current == null)
                    _current = new SaveData();
                return _current;
            }
            set => _current = value;
        }

        public List<UnitData> Units = new List<UnitData>();
    }
}