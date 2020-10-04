using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class AddressBook
    {
        public List<ContactDetails> contactList = new List<ContactDetails>();

        const int EDIT_FIRST_NAME = 1;
        const int EDIT_LAST_NAME = 2;
        const int EDIT_ADDRESS = 3;
        const int EDIT_CITY = 4;
        const int EDIT_STATE = 5;
        const int EDIT_ZIP = 6;
        const int EDIT_PHONE_NUMBER = 7;
        const int EDIT_EMAIL = 8;


        int contactSerialNum = 0;

        public string nameOfAddressBook = " ";


        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zip;
        public long phoneNumber;
        public string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public AddressBook(string nameOfAddressBook)
        {
            this.nameOfAddressBook = nameOfAddressBook;
        }

        public void AddContact()
        {
            char ch = 'y';
            while (ch == 'y' || ch == 'Y')
            {
                Console.WriteLine("\nEnter The First Name = ");
                firstName = Console.ReadLine();

                Console.WriteLine("\nEnter The Last Name =");
                lastName = Console.ReadLine();

                Console.WriteLine("\nEnter The Address =");
                address = Console.ReadLine();

                Console.WriteLine("\nEnter The City =");
                city = Console.ReadLine();

                Console.WriteLine("\nEnter The State =");
                state = Console.ReadLine();

                Console.WriteLine("\nEnter the Zip code");
                zip = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("\nEnter The phone number = ");
                phoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("\nEnter The Email of Contact");
                email = Console.ReadLine();


                ContactDetails addNewContact = new ContactDetails(firstName, lastName, address, city, state, zip, phoneNumber, email);
                contactList.Add(addNewContact);
                Console.WriteLine("\nContact Was added to the contact list");
                Console.WriteLine("Press y or Y to enter more Data OR Press any other word key to exit....");
                ch = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}
