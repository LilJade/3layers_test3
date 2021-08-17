using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy_layer
{
    public class Entity_User
    {
        private string name;
        private int age;
        private string color;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public string Color { get => color; set => color = value; }

        public Entity_User() { }

        public Entity_User(string name, int age, string color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
    }
}
