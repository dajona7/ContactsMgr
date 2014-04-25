﻿
namespace Entity.Contacts
{
    public class Contact
    {
        public int id { get; set; }
        public int memberId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public string landlineNumber { get; set; }
        public bool isActive { get; set; }
    }
}
