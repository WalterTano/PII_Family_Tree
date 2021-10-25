
namespace Library{
    public abstract class Visitor
    {
        public virtual void Visit(Node node){
            foreach(Node child in node.Children){
                child.Accept(this);
            }
            node.Person.Accept(this);
        }

        public abstract void Visit(Person person);
    }   
}