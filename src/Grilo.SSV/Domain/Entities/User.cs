using Grilo.SSV.Domain.ValueObjects;

namespace Grilo.SSV.Domain.Entities
{
    public class User : EntityBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
    }
}
