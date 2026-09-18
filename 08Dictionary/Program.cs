

class Test
{

    public static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        contacts.Add("Arpita", "9876543210");
        contacts.Add("Aniket", "9123456780");
        contacts.Add("Anuja", "9988776655");
        contacts.Add("Rutuja", "9012345678");

        System.Console.WriteLine($"\n===== CONTACT LIST =====");
        foreach (var contact in contacts)
        {
            System.Console.WriteLine($"{contact.Key} : {contact.Value}");
        }

        bool isFound = false;
        do
        {
            System.Console.Write($"\nEnter name to search :");
            string name = Console.ReadLine() ?? "";

            if (contacts.ContainsKey(name))
            {
                System.Console.WriteLine($"\nContact Found...");
                System.Console.WriteLine($"Name : {name} \nPhone : {contacts[name]} ");
                isFound = true;
                break;
            }
            else
            {
                System.Console.WriteLine($"\n{name} this name does not exist...");
            }

        } while (isFound == false);

        bool isAdd = false;
        do
        {
            System.Console.Write($"\nEnter new contact name :");
            string newName = Console.ReadLine() ?? "";

            if (contacts.ContainsKey(newName))
            {
                System.Console.WriteLine($"\n{newName} key already exist...");
            }
            else
            {
                System.Console.Write($"Enter new phone number :");
                string newPhone = Console.ReadLine() ?? "";
                contacts.Add(newName, newPhone);
                isAdd = true;
                break;
            }

        } while (isAdd == false);

        System.Console.WriteLine($"\n===== UPDATED CONTACT LIST =====");
        foreach (var contact in contacts)
        {
            System.Console.WriteLine($"{contact.Key} : {contact.Value}");
        }

        bool isUpdate = false;
        do
        {
            System.Console.Write($"\nEnter name whose number you want update : ");
            string updateName = Console.ReadLine() ?? "";

            if (contacts.ContainsKey(updateName))
            {
                System.Console.Write($"Enter new phone number : ");
                string updatePhone = Console.ReadLine() ?? "";

                contacts[updateName] = updatePhone;

                System.Console.WriteLine($"Contact update successfully !");
                isUpdate = true;
                break;
            }
            else
            {
                System.Console.WriteLine($"\n{updateName} contact not found !");
            }

        } while (isUpdate == false);

        System.Console.WriteLine($"\n===== UPDATED CONTACT LIST =====");
        foreach (var contact in contacts)
        {
            System.Console.WriteLine($"{contact.Key} : {contact.Value}");
        }

        bool isDelete = false;
        do
        {
            System.Console.Write($"\nEnter name to delete : ");
            string deleteName = Console.ReadLine() ?? "";

            if (contacts.ContainsKey(deleteName))
            {
                contacts.Remove(deleteName);
                System.Console.WriteLine($"Contact delete successfully !");
                isDelete = true;
                break;
            }
            else
            {
                System.Console.WriteLine($"{deleteName} this name does not exist !");
            }

        } while (isDelete == false);

        System.Console.WriteLine($"\n===== UPDATED CONTACT LIST =====");
        foreach (var contact in contacts)
        {
            System.Console.WriteLine($"{contact.Key} : {contact.Value}");
        }

        int totalContact = contacts.Count();
        System.Console.WriteLine($"\nTotal Contacts : {totalContact}");

    }
}