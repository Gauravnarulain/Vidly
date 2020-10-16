using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShip
    {
        public byte Id { get; set; }
        public string Title { get; set; }
        public byte DurationInMonths { get; set; }
        public byte MemberShipPrice { get; set; }
        public byte MemberShipDiscount { get; set; }
        public bool ActiveStatus { get; set; }
    }
}