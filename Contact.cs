public class Contact : PdaItem
{

    public string Address {get; set;}
    public string Phone {get; set;}

    public override string vName
    {
        get{
            return $"{ FirstName } { LastName }";
        }

        set
        {
            string[] names = value.split(' ');
            FirstName = names[0];
            LastName = names[1];
        }
    }

    private Person InternalPerson {get;set;}

    public string FirstName
    {
        get { return InternalPerson.FirstName;}
        set { InternalPerson.FirstName = value;}
    }

        public string LastName
    {
        get { return InternalPerson.LastName;}
        set { InternalPerson.LastName = value}
    }
}