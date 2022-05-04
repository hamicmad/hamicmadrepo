using ContactSystem;



ContactManager contactManager = new ContactManager();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Выберите нужную операцию:");
    Console.WriteLine("1.Добавить новый контакт \t 2.Изменить контакт(по введенному Id) \t 3.Удалить контакт (по введенному Id) \n");
    Console.WriteLine("4.Найти контакты по введенному имени \t 5.Вывести все существующие контакты \t 6.Выход");

    var input = Console.ReadKey(true);
    

    switch (input.KeyChar)
    {
        case '1':
            Contact contact = new Contact();
            Console.WriteLine("Введите Имя");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            contact.NumberPhone = Console.ReadLine();
            contactManager.AddNew(contact);
            Console.WriteLine("Контакт добавлен");
            break;
        case '2':
            Console.WriteLine("Введите Id контакта");
            var id1 = Console.ReadLine();
            if (int.TryParse(id1, out int idDelete))
                contactManager.Delete(idDelete);
            Console.WriteLine("Контакт удален");
            break;
        case '3':
            Console.WriteLine("Введите Id контакта");
            var id2 = Console.ReadLine();
            Console.WriteLine("Введите имя");
            var newName = Console.ReadLine();
            Console.WriteLine("Введите номер");
            var newPhone = Console.ReadLine();
            var contact1 = new Contact {Name = newName, NumberPhone = newPhone};

            if (int.TryParse(id2, out int idDelete1))
            {
                contactManager.Change(idDelete1, contact1);
            }
            Console.WriteLine("Контакт изменен");
            break;
        case '4':
            Console.WriteLine("Введите имя контакта");
            var contactName = Console.ReadLine();
            var foundContacts = contactManager.FindByName(contactName);
            foreach (var s in foundContacts)
            {
                Console.WriteLine(s.ToString());
            }
            break;
        case '5':
            var allContacts = contactManager.ViewAll();
            foreach (var all in allContacts)
            {
                Console.WriteLine(all.ToString());
            }    
            break;
        case '6':
            return;
        default:
            Console.WriteLine("Неверная команда. Попробуйте еще раз.\n");
            break;

    }

}


Console.ReadLine();