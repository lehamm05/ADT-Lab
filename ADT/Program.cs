using System;
using System.Xml;
using ADT;

namespace ADT
{
    class Program
    {

        static void Main()
        {
            OrganizationNamesProvider organization = new OrganizationNamesProvider();
            List<Person> members = organization.getNames();
           
            Phone newphone = new Phone("088756789");
            PhoneBook pb = new PhoneBook(members);
            pb.addEntry("Alve", newphone);
            Phone newphone2 = new Phone("000");
            pb.addEntry("Alve", newphone2);
            
            List<Phone> foundPhones = pb.findPhones("Alve");
            pb.removeEntry(newphone2, "Alve");
        }
    }
}
