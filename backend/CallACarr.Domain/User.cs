using System;

namespace CallACarr.Domain
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool HasDriverLicense { get; set; } // user should be verified in advance
    }
}