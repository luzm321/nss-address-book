namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // getter that computes contact object's full name by string interpolation:
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // Contact class constructor to create contact object not need as will be using default constructor to instantiate Class
        // public Contact(string firstName, string lastName, string email, string address)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     Email = email;
        //     Address = address;
        // }

    }
}