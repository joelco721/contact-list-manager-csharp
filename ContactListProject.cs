using System;

public class Intro
{
    public static void Enter()
    {
        Console.WriteLine("Welcome to your very own to do list.");

    }

}

public class Contacts
{
    public string Name;
    public string Phone;
    public string Email;

    public Contacts(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;

    }


}



public class ToDoList
{

    public static List<Contacts> items = new List<Contacts>();
    public static string AddItem()
    {

       Console.WriteLine("Create name for the list:");
       string name = Console.ReadLine();
       Console.WriteLine($"For name: {name} what is his phone number:");
       string phone = Console.ReadLine();
       Console.WriteLine($"For name {name} what is his email:");
       string email = Console.ReadLine();
       Contacts person = new Contacts(name, phone, email);
       items.Add(person);
       return $"For {name} contacts has been saved";
    }


     public static string Checklist()
    {
        Console.WriteLine("Please write the first name of the list you want to check");
        string checkName = Console.ReadLine();
        foreach (Contacts contact in items)
        { 
            if (contact.Name == checkName)
            {
                return $"{contact.Name} {contact.Phone} {contact.Email}";

            }

        }
        return "not found";

    }


    public static string Removelist()
    {
        
       Console.WriteLine("Please write the first name of the person you want to remove");
       string checkName = Console.ReadLine();
       bool removed = false;
       foreach (Contacts contacts in items)
        {
            if (contacts.Name == checkName)
            {
                Console.WriteLine($"Is this the person you want to remove? {contacts.Name}?\nY for yes or N for no?");
                string yesorno = Console.ReadLine();

                if (yesorno == "y" || yesorno == "yes")
                {
                    items.Remove(contacts);
                    Console.WriteLine($"The person was removed!");
                    removed = true;


                }
                else
                {
                    return "Invalid input";

                }

            }
            
  
        }
        if (removed) return "Done!";
        return "Not Found";

    }


}
//

public class Welcome
{
    public static string Greeting()
    {

      while (true)
      {
        Console.WriteLine("1. Create to do list\n2. Check list\n3. Remove list\n4. Exit");
        int.TryParse(Console.ReadLine(), out int menu);

        switch (menu)
        {
            case 1: Console.WriteLine(ToDoList.AddItem()); break;
            case 2: Console.WriteLine(ToDoList.Checklist()); break;
            case 3: Console.WriteLine(ToDoList.Removelist()); break;
            case 4: Environment.Exit(0); break;
            default: Console.WriteLine("Invalid input"); break;
        

        }

      }


    }

}

public class Starter
{
    public static void Main()
    {
        Intro.Enter();
        Console.WriteLine(Welcome.Greeting());


    }


}