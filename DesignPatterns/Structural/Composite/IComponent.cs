using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    interface IComponent <T>
    {
        void Add(IComponent<T> c);
        IComponent<T> Remove(T s);
        string Display(int depth);
        IComponent<T> Find(T s);
        T Name { get; set; }
    }
}
