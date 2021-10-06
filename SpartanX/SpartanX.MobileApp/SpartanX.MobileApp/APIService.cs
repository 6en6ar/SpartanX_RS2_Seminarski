using Flurl.Http;
using ModelSpartanX;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpartanX.MobileApp
{
    public class APIService
    {
        private string _controllerRoute = null;
        public static string username { get; set; }
        public static string password { get; set; }

#if DEBUG 
        string Apiurl = "http://localhost:5000";
#endif
#if RELEASE
        string url = "http://6en6ar.github.io";
#endif
        public APIService(string ControllerRoute)
        {
            _controllerRoute = ControllerRoute;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Apiurl}/{ _controllerRoute}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
                return result;
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Greska","Username ili lozinka nisu validni!","OK");
                throw;
            }

        }
        public async Task<T> GetById<T>(object id)
        {
            var url = await $"{ Apiurl}/{ _controllerRoute}/{id}".WithBasicAuth(username, password).GetJsonAsync<T>();
            return url;

        }
        public async Task<T> Insert<T>(object req)
        {
            var url = $"{ Apiurl}/{ _controllerRoute}";
            var result = await url.WithBasicAuth(username, password).PostJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Update<T>(object id, object req)
        {
            var url = $"{Apiurl}/{ _controllerRoute}/{id}";
            var result = await url.WithBasicAuth(username, password).PutJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Delete<T>(object id)
        {
            //provjeriti delete
            var url = $"{ Apiurl}/{ _controllerRoute}/{id}";
            var result = await url.WithBasicAuth(username, password).DeleteAsync();
            return (T)result;


        }
    }
}
