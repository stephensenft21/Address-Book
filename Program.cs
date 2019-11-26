using System;
using System.Collections.Generic;
namespace AddressBook
{
    class Program
    {
        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */

        static void Main(string[] args)
        {
            // Create a few contacts
            Contact Frank = new Contact()
            {
                FirstName = "Frank",
                LastName = "Brown",
                Email = "FrankBrown@nashville.com",
                Address = "100 BS Ln, Nashville, TN 15551"
            };
            Contact Mary = new Contact()
            {
                FirstName = "Maru",
                LastName = "Jones",
                Email = "Mary.mary@email.com",
                Address = "322 soft ln, Testville, TN 55555"
            };
            Contact Beevis = new Contact()
            {
                FirstName = "Beevis",
                LastName = "Lopez",
                Email = "Beevis.lopez@email.com",
                Address = "888 sleasy St, Cashville, TN 55555"
            };

            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(Frank);
            addressBook.AddContact(Mary);
            addressBook.AddContact(Beevis);

            // Try to addd a contact a second time
            addressBook.AddContact(Mary);
            addressBook.AddContact(Frank);
            addressBook.AddContact(Beevis);

            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>()
            {
                "FrankBrown@nashville.com",
                "Beevis.lopez@email.com",
                "Mary.mary@email.com",
            };

            // Insert an email that does NOT match a Contact
            emails.Insert(1, "hello.addressbook@email.com");

            //  Search the AddressBook by email and print the information about each Contact
            foreach (string email in emails)
            {
                try
                {
                    Contact contact = addressBook.getByEmail(email);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Name: {contact.FullName}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine($"Address: {contact.Address}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Contact not in address book!!!!");
                }
            }
        }
    }
}