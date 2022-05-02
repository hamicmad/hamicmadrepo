using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSystem
{
    public class ContactManager
    {
        List<Contact> contacts = new List<Contact>();
       

        public void AddNew(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Контакт добавлен");
        }
        public void Delete(int id)
        {
            for (int i = 0; i < contacts.Count; i++)
                if (contacts[i].Id == id)
                    contacts.RemoveAt(i);
            Console.WriteLine("Контакт удален");

        }
        public void Change(int id)
        {
            for (int i = 0; i < contacts.Count; i++)
                if (contacts[i].Id == id)
                {
                    Console.WriteLine("Введите имя и номер");
                    contacts[i].Name = Console.ReadLine();
                    contacts[i].NumberPhone = Console.ReadLine();
                    Console.WriteLine("Контакт изменен");
                }
        }
        public void FindByName(string name)
        {
            Console.WriteLine(contacts.Find(contact => contact.Name.IndexOf(name, StringComparison.CurrentCultureIgnoreCase) >=0).ToString());
        }
        public void ViewAll()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }

        }
        
    }

}
