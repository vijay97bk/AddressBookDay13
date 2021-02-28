﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay13
{
    public class AddressBook
    {
        public bool found = false;
        public List<Person> addressBook;
        public AddressBook()
        {
            addressBook = new List<Person>();
        }

        public void AddAddressBookEntry(Person person)
        {
            addressBook.Add(person);
        }
        /// <summary>
        /// Adding new entry and checking for duplicate entry UC7
        /// </summary>
        public void AddAddressBookEntry()
        {
            Person personEntered = new Person();
            Console.WriteLine("Enter First name");
            personEntered.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            personEntered.lastName = Console.ReadLine();
            
            //Checking for entered person is already exists UC7

            if (addressBook.Find(i => personEntered.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }
            Console.WriteLine("Enter Address");
            personEntered.address = Console.ReadLine();
            Console.WriteLine("Enter City");
            personEntered.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            personEntered.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            personEntered.zip = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber");
            personEntered.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            personEntered.email = Console.ReadLine();
            addressBook.Add(personEntered);
        }
        /// <summary>
        /// Displaying all all names
        /// </summary>
        public void DisplayNamesInAddresBook()
        {
            if (addressBook.Count == 0)
            {
                Console.WriteLine("No Names to Display");
            }
            foreach (Person person in addressBook)
            {
                person.DisplayPerson();
            }
        }
        /// <summary>
        /// Editing contact through "firstName" and "LastName"
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void EditContact(string firstName, string lastName)
        {
            int index = 0;

            //try to make new method for searching

            bool found = false;
            foreach (Person person in addressBook)
            {
                if (person.firstName == firstName && person.lastName == lastName)
                {
                    found = true;
                    break;
                }
                index++;
            }
            if (found == true)
            {
                Console.WriteLine("Enter First name");
                addressBook[index].firstName = Console.ReadLine();
                Console.WriteLine("Enter Last name");
                addressBook[index].lastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                addressBook[index].address = Console.ReadLine();
                Console.WriteLine("Enter City");
                addressBook[index].city = Console.ReadLine();
                Console.WriteLine("Enter State");
                addressBook[index].state = Console.ReadLine();
                Console.WriteLine("Enter Zip");
                addressBook[index].zip = Console.ReadLine();
                Console.WriteLine("Enter phoneNumber");
                addressBook[index].phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Email");
                addressBook[index].email = Console.ReadLine();
            }
            else
                Console.WriteLine("enterd contact not found in address book ");
        }

        /// <summary>
        /// deleting contact
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void DeleteContact(string firstName, string lastName)
        {
            
            
           int index= Searching(firstName, lastName, this.found);
            if (this.found)
                addressBook.Remove(addressBook[index]);
            else
                Console.WriteLine("Entry Not found");
        }
        public int Searching(string firstName, string lastName, bool found)
        {

            int index = 0;
           
            foreach (Person person in addressBook)
            {
                if (person.firstName == firstName && person.lastName == lastName)
                {
                    this.found = true;
                    break;
                }
                index++;
                    
            }
            return index;
           
        }

    }
}