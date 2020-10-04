using System;

namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name Of Address Book=");
            string addressBookName = Console.ReadLine();
            AddressBook addressBook = new AddressBook(addressBookName);
        // Driving the Execution through menu guidation
        Outer:
            Console.WriteLine("******************************************");
            Console.WriteLine("Welcome to the {0}'s Address Book",addressBookName);
            Console.WriteLine("******************************************");
            Console.WriteLine("1. Create A New Contact");
            Console.WriteLine("2. Edit a contact");
            Console.WriteLine("3. Delete a contact");
            Console.WriteLine("4. Display Stored Contact");
            Console.WriteLine("Press any Key to Exit!!!!!!!");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    Console.Clear();
                    break;

                case 2:
                    addressBook.editContactDetails();
                    Console.Clear();
                    break;

                case 3:
                    addressBook.deleteDetails();
                    Console.Clear();
                    break;

                case 4:
                    addressBook.displayDetails();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Enter the correct choice Please!!!!!!");
                    break;

            }
            goto Outer;


        }
    }
}
