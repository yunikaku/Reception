using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception.Service
{
    internal class PreferencesService : interfacePreferences
    {
        public string SaveData(string key, string value)
        {
            try
            {
                Preferences.Set(key, value);

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }




        public string LoadData(string key)
        {
            try
            {
                var data = Preferences.Get(key, string.Empty);

                return data;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public string FastLoad(string key)
        {
            try
            {
                var data = Preferences.Get(key, string.Empty);
                if (data == "")
                {
                    return null;
                }
                return data;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

}
