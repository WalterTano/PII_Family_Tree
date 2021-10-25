
namespace Library{
    public class VisitorAgeSum : Visitor
    {
        public int AgeSum { get; set; }

        public override void Visit(Person person){
            this.AgeSum += person.Age;
        }
    }   
}