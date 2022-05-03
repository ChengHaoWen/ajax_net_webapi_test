using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Webapitest.Models
{
    public partial class TOrder
    {
        public int FId { get; set; }
        public string FOrderGuid { get; set; }
        public string FUserId { get; set; }
        public string FReceiver { get; set; }
        public string FEmail { get; set; }
        public string FAddress { get; set; }
        public DateTime? FDate { get; set; }
    }
}
