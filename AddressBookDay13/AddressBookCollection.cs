using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay13
{
    class AddressBookCollection
    {
        public Dictionary<string, AddressBook> addressBookDictionary;//Dictionary collection
        public AddressBookCollection()
        {
            addressBookDictionary = new Dictionary<string, AddressBook>();
        }
        public void PrintAllAddressBookNames()
        {
            foreach (var AddressBookItem in addressBookDictionary)
            {
                Console.WriteLine(AddressBookItem.Key);
            }
        }
    }
}

 
     