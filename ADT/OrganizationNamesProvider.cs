namespace ADT
{
    public class OrganizationNamesProvider
    {
        public List<Person> getNames(){
            List<Person> members = new List<Person>();
            members.Add(member0);
            members.Add(member1);
            return members;
        }
        // Define members here
        Person member0 = new Person ("Alve");
        Person member1 = new Person ("Bjarne");     
    }
}