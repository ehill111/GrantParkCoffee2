using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        //Researched Sessions: https://www.c-sharpcorner.com/article/passing-data-from-controller-to-view-using-session-part-five/
        //Other articles and YouTube.
        //Sessions is a property of Controller class. Allows data to be passed from one page to another.
        //Also a session object can hold info about user and make available throughout application. Powerful!
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            //If null, will go to default. Otherwise, will DeserializeObject to type T.
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }

    }
}
