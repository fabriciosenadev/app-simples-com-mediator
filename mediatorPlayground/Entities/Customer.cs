namespace mediatorPlayground.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }

        public Customer(string fullName, 
            string phoneNumber,
            string email,
            List<string> tags)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Tags = tags;
        }
    }
}
