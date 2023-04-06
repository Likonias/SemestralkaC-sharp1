using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SemestralkaLibrary
{
    public class FileSerializerDeserializer<T>
    {

        private readonly ISavableLoadable<T> entities;
        private readonly string file;

        public FileSerializerDeserializer(ISavableLoadable<T> entities, string file)
        {
            this.entities = entities;
            this.file = file;
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(this.file))
            {
                foreach (var entities in entities.Save())
                {
                    sw.WriteLine(Serialize(entities));
                }
                sw.Flush();
                sw.Close();
            }
        }

        public void Load()
        {
            var entitiesLoad = new List<T>();
            using (var sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    entitiesLoad.Add(Deserialize(line));
                }
                sr.Close();
            }
            entities.Load(entitiesLoad.ToArray());
        }

        private static string Serialize(T entity)
        {
            return JsonSerializer.Serialize(entity);
        }

        private static T Deserialize(string line)
        {
            return JsonSerializer.Deserialize<T>(line);
        }

    }

}

