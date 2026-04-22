namespace ContactManager.Core;

public class Menu(IConsole console, ContactService service)
{
    public int Run()
    {
        var running = true;
        while (running)
        {
            ShowMenu();
            running = HandleChoice(console.ReadLine());

        }
        return 0;
    }
    private void ShowMenu()
    {
        console.WriteLine("1. Contact Toevoegen");
        console.WriteLine("q. Exit");
        console.Write("Maak uw keuze:");
    }
    private void HandleAddContact()
    {
        console.Write("Voer een naam in: ");  // ask for name
        var name = console.ReadLine();         // read what user types
        service.AddContact(name);             // save it
        console.WriteLine("Contact toegevoegd: " + name); // confirm
    }
    private bool HandleChoice(string choice)
    {
        switch (choice)
        {
            case "1": HandleAddContact(); break;
            case "q": return false;
            default: console.WriteLine("Ongeldige optie."); break;
        }
        return true;


    }
}