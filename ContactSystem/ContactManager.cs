using System;
using System.Collections.Generic;


namespace ContactSystem
{
    public class ContactManager
    {
        List<Contact> contacts = new List<Contact>();
       

        public void AddNew(Contact contact)
        {
            contacts.Add(contact);
        }
        public void Delete(int id)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Id == id)
                    contacts.RemoveAt(i);
            }
        }
        public void Change(int id, Contact contact)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Id == id)
                {
                    contacts[i].Name = contact.Name;
                    contacts[i].NumberPhone = contact.NumberPhone;
                }
            }
        }
        public List <Contact> FindByName(string name)
        {
            List <Contact> foundContacts = new List <Contact>();

            foreach (var contact in contacts)
            {
                if (contact.Name.ToUpper() == name.ToUpper())
                {
                    foundContacts.Add(contact);
                }
            }
        return foundContacts;  
        }
        public List<Contact> ViewAll()
        {
          return  new List<Contact>();  
        }
        
    }

}
