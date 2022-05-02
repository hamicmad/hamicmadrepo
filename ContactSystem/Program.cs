using ContactSystem;

bool isExit = false;
ContactManager contactManager = new ContactManager();


do
{
    Console.WriteLine("Выберите нужную операцию:");
    Console.WriteLine("1.Добавить новый контакт");
    Console.WriteLine("2.Изменить контакт(по введенному Id)");
    Console.WriteLine("3.Удалить контакт (по введенному Id)");
    Console.WriteLine("4.Найти контакты по введенному имени");
    Console.WriteLine("5.Вывести все существующие контакты");
    Console.WriteLine("6.Выход");

    string input = Console.ReadLine();
    int result = 0;
    bool operation = int.TryParse(input, out result);

    switch (result)
    {
        case 1:
            Contact contact = new Contact();
            Console.WriteLine("Введите Имя");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            contact.NumberPhone = Console.ReadLine();
            contactManager.AddNew(contact);
            break;
        case 2:
            Console.WriteLine("Введите Id контакта");
            var id1 = Console.ReadLine();
            if (int.TryParse(id1, out int idDelete))
                contactManager.Delete(idDelete);
            break;
        case 3:
            Console.WriteLine("Введите Id контакта");
            var id2 = Console.ReadLine();
            if (int.TryParse(id2, out int idDelete1))
                contactManager.Change(idDelete1);
            break;
        case 4:
            Console.WriteLine("Введите имя контакта");
            var contactName = Console.ReadLine();
            contactManager.FindByName(contactName);
            break;
        case 5:
            contactManager.ViewAll();
            break;
        case 6:
            isExit = true;
            break;
        default:
            Console.WriteLine("Неверная команда. Попробуйте еще раз.\n");
            break;
            Console.WriteLine();
    }
} while (!isExit);
Console.ReadLine();