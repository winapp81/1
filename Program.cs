public class Program
{
    // Contact contact = new Contact();
    // contact.Name = "park";

    // Contact contact2 = new Contact();
    // PdaItem item = contact2;

    // contact = (Contact)item;

    public static void Main()
    {
        PdaItem[] pda  = new PdaItem[3];

        Contact contact = new Contact("Sherlock Holmes");
        contact.Address = "221B Baker Street, London, England";
        pda[0] = contact;
        
    }
    
}