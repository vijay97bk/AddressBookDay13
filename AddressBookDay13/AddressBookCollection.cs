using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay13
{
    /// <summary>
    /// Creating Collection
    /// </summary>
    public class AddressBookCollection
    {
        public Dictionary<string, AddressBook> addressBookDictionary;
        public AddressBookCollection()
        {
            addressBookDictionary = new Dictionary<string, AddressBook>();
        }
        /// <summary>
        /// Printing all address book names
        /// </summary>
        public void PrintAllAddressBookNames()
        {
            foreach (var AddressBookItem in addressBookDictionary)
            {
                Console.WriteLine(AddressBookItem.Key);
            }
        }
        /// <summary>
        /// UC8 searching persons City and state
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void SearchPersonInCityOrState(string firstName, string lastName)
        {
           
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> PersonInCitiesOrStates = addressBookEntry.Value.addressBook.FindAll(i => (i.firstName == firstName) && (i.lastName == lastName));
                
                //I have to add if condition here to check person exists or not, if not then print "person not exists in addressBook"

                foreach (Person person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.firstName} {person.lastName} is in {person.city} {person.state}");
                }
            }
        }
    }
}