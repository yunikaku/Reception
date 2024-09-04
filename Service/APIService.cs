using System.Text;
using System.Net;

using Reception.Models;
using Newtonsoft.Json;



namespace Reception.Service
{
    internal class APIService : InterfaceAPI
    {
        private string _baseUrl = "https://localhost:7117/api/";

        public async Task<EmployeeReservation> GetEmployeeReservations(int id)
        {
            using (var client =new HttpClient()) 
            {
                var url = _baseUrl + APIs.EmployeeReservations + "?EmployeeReservationsID=" + id;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync();
                    List<EmployeeReservation> employeeReservations = JsonConvert.DeserializeObject<List<EmployeeReservation>>(content.Result);
                    if (employeeReservations.Count > 0)
                    {
                        foreach (var employeeReservation in employeeReservations)
                        {
                            if (employeeReservation.EmployeeReservationsId == id)
                            {
                                return employeeReservation;

                            }
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        //Put
        public async Task<bool> SetNFC(SetNfc setNfc)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Nfc;
                var json = JsonConvert.SerializeObject(setNfc);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public async Task<NotReservation> PostNotReservation(postNotReservation postNotReservation)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NotReservations;
                var json = JsonConvert.SerializeObject(postNotReservation);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync();
                    NotReservation notReservation = JsonConvert.DeserializeObject<NotReservation>(content.Result);
                    return notReservation;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<bool> GroupSlack(string GroupSlakId, string text)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Slak + "?GroupSlakId=" + GroupSlakId + "&text=" + text;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> DMSlack(string SlakURL, string text)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Slak + "?SlakURL=" + SlakURL + "&text=" + text;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

