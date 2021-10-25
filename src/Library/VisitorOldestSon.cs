
namespace Library{
    public class VisitorOldestSon : Visitor
    {
        public Person OldestSon { get; set; }

        public override void Visit(Node node){
            if(node.Children.Count > 0){
                foreach(Node child in node.Children){
                    child.Accept(this);
                }
            } else {
                node.Person.Accept(this);
            }
        }

        public override void Visit(Person person){
            this.OldestSon = this.OldestSon != null && this.OldestSon.Age > person.Age ? this.OldestSon : person;
        }
    }   
}