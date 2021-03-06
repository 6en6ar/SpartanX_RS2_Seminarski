using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Flurl;
using System.Threading.Tasks;
using ModelSpartanX;

namespace SpartanX.WinUI
{
 
    public class APIService
    {
        private string _controllerRoute = null;
        public static string username { get; set; }
        public static string password { get; set; }
        public APIService(string ControllerRoute)
        {
            _controllerRoute = ControllerRoute;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _controllerRoute}";
            if(search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(username,password).GetJsonAsync<T>();
            return result;

        }
        public async Task<T> GetById<T>(object id)
        {
            var url = await $"{ Properties.Settings.Default.APIUrl}/{ _controllerRoute}/{id}".WithBasicAuth(username, password).GetJsonAsync<T>();
            return url;

        }
        public async Task<T> Insert<T>(object req)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _controllerRoute}";
            var result = await url.WithBasicAuth(username, password).PostJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Update<T>(object id, object req)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _controllerRoute}/{id}";
            var result = await url.WithBasicAuth(username, password).PutJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Delete<T>(object id)
        {
            //provjeriti delete
            var url = $"{ Properties.Settings.Default.APIUrl}/{ _controllerRoute}/{id}";
            var result = await url.WithBasicAuth(username, password).DeleteAsync();
            return (T)result;
   

        }
    }
}
