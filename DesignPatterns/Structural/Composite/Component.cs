﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            Name = name;
        } 
        public void Add(IComponent<T> c)
        {
            Console.WriteLine("Cannot add to an item");
        }

        public IComponent<T> Remove(T s)
        {
            Console.WriteLine("Cannot remove to an item");
            return this;
        }

        public string Display(int depth)
        {
            return new string('-', depth) + Name + "\n";
        }

        public IComponent<T> Find(T s)
        {
            if(s.Equals(Name))
            {
                return this;
            } 
            else
            {
                return null;
            }
        }

    }
}
