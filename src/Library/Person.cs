using System;

namespace Library
{
    public class Person
    {
        public Person(string name, int age){
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; set; }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
