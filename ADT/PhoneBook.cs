namespace ADT
{
    public class PhoneBook
    {
        public Dictionary<Person, List<Phone>> telephones = new Dictionary<Person, List<Phone>>();
        private List<Person> members;
        public PhoneBook (List<Person> pmembers){
            members = pmembers;
        }

        public void addEntry(String name, Phone newnumber){
            Person pers = null;
            foreach (Person member in members){
                if (member.getName().Equals(name)){
                    pers = member;
                    if (telephones.ContainsKey(member) && !telephones[member].Contains(newnumber)){
                        telephones[member].Add(newnumber);
                    }
                    else{
                        telephones.Add(member, new List<Phone>(){newnumber});
                    }
                }
            }
            try{
                Console.WriteLine("Added Number for " + pers.getName() + " : " + newnumber.getPhone());
            }
            catch (NullReferenceException){
                Console.WriteLine("Not a member");
            } 
        }
        public List<Phone> findPhones(String name){
            List<Phone> foundTelephones = null;
            foreach (var entry in telephones){
                if(entry.Key.getName() == name){
                    foundTelephones =  entry.Value;
                }
            }
            try {
                foreach (Phone phonenumber in foundTelephones){
                    Console.WriteLine(phonenumber.getPhone());
                }
            }
            catch(NullReferenceException){
                Console.WriteLine("User not found");
            }
            return foundTelephones;    
        }
        public void removeEntry(Phone oldnumber, String name){
            try{
                bool success = false;
                foreach (var entry in telephones){
                    if(entry.Key.getName() == name && entry.Value.Contains(oldnumber)){
                        entry.Value.Remove(oldnumber);
                        Console.WriteLine("Removed " + oldnumber.getPhone());
                        success = true;
                        if (entry.Value.Count()==0){
                            telephones.Remove(entry.Key);
                        }
                    }

                }
                if (success == false){
                    throw new EntryNotFoundException("Entry not found");
                }
            }
            catch (EntryNotFoundException  e){
                Console.WriteLine($"Exeption caught. {e.Message}");
            }
        }
    }
}