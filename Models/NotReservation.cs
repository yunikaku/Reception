using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception.Models
{
    public class NotReservation
    {
        public int NotReservationId { get; set; }
        public string NotReservationName { get; set; }
        public string NotReservationRequirement { get; set; }
        public string? NotReservationCompanyName { get; set; }
    }
    public class postNotReservation
    {
        public string NotReservationName { get; set; }
        public string NotReservationRequirement { get; set; }
        public string? NotReservationCompanyName { get; set; }
    }
}
