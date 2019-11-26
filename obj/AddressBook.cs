using System;
using System.Collections.Generic;

namespace AddressBook
{

    public class AddressBook
    {
        public List<Contact> Contacts {get; set;} = new List<Contact>();
        public void AddContact(Contact contact) {


            this.Contacts.Add(contact);

        }

        public Contact getByEmail(string email) {
             foreach(Contact contact in Contacts) {
              
        if(contact.Email == email) {

            return contact;
        }

             }
             return null;



        }


    
        

    }

}