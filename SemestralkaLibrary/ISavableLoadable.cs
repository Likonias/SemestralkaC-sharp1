using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaLibrary
{
    public interface ISavableLoadable<T>
    {
        T[] Save();
        void Load(T[] data);
    }
}
