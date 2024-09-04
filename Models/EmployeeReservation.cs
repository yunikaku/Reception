using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception.Models
{
    public class EmployeeReservation
    {
        public int EmployeeReservationsId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public int ClientCompanyEmployeesId { get; set; }

        public string ClientCompanyEmployeesName { get; set; }

        public DateTime ReservationsTime { get; set; }

        public byte[] Qr { get; set; }

        public string CompleteFlag { get; set; }

        public string Requirement { get; set; }
    }
}
