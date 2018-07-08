public class Program
{
    Contact contact = new Contact();
    contact.Name = "park";

    Contact contact2 = new Contact();
    PdaItem item = contact2;

    contact = (Contact)item;
    
}