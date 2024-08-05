namespace mediatorPlayground.Commands.AddCustomerWithoutMediatr 
{ 
    public class AddCustomerWithoutMediatrCommand
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }
    }
}
