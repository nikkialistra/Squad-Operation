﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Saving.Serialization.Surrogates;
using UnityEngine;

namespace Saving.Serialization
{
    public class SerializationManager
    {
        public static bool Save(string saveName, object saveData)
        {
            var formatter = GetBinaryFormatter();

            var basePath = Path.Combine(Application.persistentDataPath, "saves");
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            var path = Path.Combine(basePath, saveName);

            var file = File.Create(path);
            
            formatter.Serialize(file, saveData);
            
            file.Close();

            return true;
        }

        public static object Load(string loadName)
        {
            var path = Path.Combine(Application.persistentDataPath, "saves", loadName);

            if (!File.Exists(path))
                throw new ArgumentException(nameof(loadName));

            var formatter = GetBinaryFormatter();

            var file = File.Open(path, FileMode.Open);

            try
            {
                var save = formatter.Deserialize(file);
                file.Close();
                return save;
            }
            catch 
            {
                file.Close();
                throw new FileLoadException($"Failed to load file at {loadName}");
            }
        }

        private static BinaryFormatter GetBinaryFormatter()
        {
            var formatter = new BinaryFormatter();
            
            var selector = new SurrogateSelector();
            
            var vector3Surrogate = new Vector3SerializationSurrogate();
            var quaternionSurrogate = new QuaternionSerializationSurrogate();
            
            selector.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), vector3Surrogate);
            selector.AddSurrogate(typeof(Quaternion), new StreamingContext(StreamingContextStates.All), quaternionSurrogate);

            formatter.SurrogateSelector = selector;

            return formatter;
        }
    }
}