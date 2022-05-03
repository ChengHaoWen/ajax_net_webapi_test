using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Webapitest.Models
{
    public partial class TOrderDetail
    {
        public int FId { get; set; }
        public string FOrderGuid { get; set; }
        public string FUserId { get; set; }
        public string FPid { get; set; }
        public string FName { get; set; }
        public int? FPrice { get; set; }
        public int? FQty { get; set; }
        public string FIsApproved { get; set; }
    }
}
