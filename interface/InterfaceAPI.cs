using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reception.Models;


namespace Reception
{
    public interface InterfaceAPI
    {
        public Task<EmployeeReservation> GetEmployeeReservations(int id);

        public Task<bool> SetNFC(SetNfc setNfc);

        public Task<NotReservation> PostNotReservation(postNotReservation postNotReservation);

        public Task<bool> GroupSlack(string GroupSlakId, string text);

        public Task<bool> DMSlack(string SlakURL, string text);
    }
} 
