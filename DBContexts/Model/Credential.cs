using System;
using System.Collections.Generic;
namespace test_naimul.DBContexts.Model
{
    public partial class Credential
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsBlock { get; set; }
    }
}
