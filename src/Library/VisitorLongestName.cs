
namespace Library{
    public class VisitorLongestName : Visitor
    {
        public string LongestName { get; set; }

        public override void Visit(Person person){
            this.LongestName = this.LongestName != null && this.LongestName.Length > person.Name.Length ? this.LongestName : person.Name;
        }
    }   
}