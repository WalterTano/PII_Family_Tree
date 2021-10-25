using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Person("Juan González", 80));
            Node n2 = new Node(new Person("José González", 55));
            Node n3 = new Node(new Person("Gilberto González", 52));
            Node n4 = new Node(new Person("Juana González", 50));
            Node n5 = new Node(new Person("Carlos Rodríguez", 25));
            Node n6 = new Node(new Person("Roberto González", 30));
            Node n7 = new Node(new Person("María Rodrígez", 18));

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n6);

            n4.AddChildren(n5);
            n4.AddChildren(n7);

            VisitorAgeSum visitorAgeSum = new VisitorAgeSum();
            VisitorOldestSon visitorOldestSon = new VisitorOldestSon();
            VisitorLongestName visitorLongestName = new VisitorLongestName();
            n1.Accept(visitorAgeSum);
            n1.Accept(visitorOldestSon);
            n1.Accept(visitorLongestName);
            System.Console.WriteLine(visitorAgeSum.AgeSum 
            + "\n" + visitorOldestSon.OldestSon.Name + ", " + visitorOldestSon.OldestSon.Age 
            + "\n" + visitorLongestName.LongestName);
        }
    }
}
