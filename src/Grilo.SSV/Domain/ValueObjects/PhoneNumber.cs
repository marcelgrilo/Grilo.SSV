namespace Grilo.SSV.Domain.ValueObjects
{
    public class PhoneNumber
    {
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool IsMobile { get; set; }

        public PhoneNumber(string phone, bool isMobile)
        {
            Phone = phone;
            IsMobile = IsMobile;
        }
    }
}
