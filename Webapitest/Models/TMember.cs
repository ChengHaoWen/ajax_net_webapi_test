using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Webapitest.Models
{
    public partial class TMember
    {
        public int FId { get; set; }
        public string FUserId { get; set; }
        public string FPwd { get; set; }
        public string FName { get; set; }
        public string FEmail { get; set; }
    }
}
