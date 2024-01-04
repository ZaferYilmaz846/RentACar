using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Model.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
