using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception.Models
{
    public class Nfc
    {
    }
    public class SetNfc
    {
        public string CardUid { get; set; }

        public int? ClientCompanyEmployeesId { get; set; }

        public int? NotReservationId { get; set; }

        public string? NfcPayload { get; set; }

    }
}
