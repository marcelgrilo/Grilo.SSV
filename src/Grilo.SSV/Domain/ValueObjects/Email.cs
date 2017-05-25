namespace Grilo.SSV.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; set; }
        public Email(string email)
        {
            this.Value = email;
        }
    }
}
