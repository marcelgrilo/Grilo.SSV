using Grilo.SSV.Domain.ValueObjects;
using System.Collections.Generic;

namespace Grilo.SSV.Domain.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<PhoneNumber> PoneNumbers { get; set; }
        public Email Email { get; set; }



    }
}
