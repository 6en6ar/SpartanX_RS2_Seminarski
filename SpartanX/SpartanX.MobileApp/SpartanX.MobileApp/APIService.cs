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
        public async Task<T> Authenticate<T>(string username, string password)
        {
            var url = $"{Apiurl}/{_controllerRoute}/Authenticate/{username},{password}";

            return await url.GetJsonAsync<T>();
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
                var result = await url.GetJsonAsync<T>();
                return result;
            }
            catch(FlurlHttpException ex)
            {
                if(ex.Call.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await App.Current.MainPage.DisplayAlert("Greska", "Username ili lozinka nisu validni!", "OK");
                }
                throw;
            }

        }
        public async Task<T> GetById<T>(object id)
        {
            var url = await $"{ Apiurl}/{ _controllerRoute}/{id}".GetJsonAsync<T>();
            return url;

        }
        public async Task<T> Insert<T>(object req)
        {
            var url = $"{ Apiurl}/{ _controllerRoute}";
            var result = await url.PostJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Update<T>(int id, object req, string username, string password)
        {
            var url = $"{ Apiurl}/{ _controllerRoute}/{id}/{username},{password}";
            var result = await url.PutJsonAsync(req).ReceiveJson<T>();
            return result;

        }
        public async Task<T> Recommend<T>(int id)
        {
            var url = $"{Apiurl}/{ _controllerRoute}/Recommend/{id}";

            return await url.GetJsonAsync<T>();

        }
       
        public async Task<T> Delete<T>(object id)
        {
            //provjeriti delete
            var url = $"{ Apiurl}/{ _controllerRoute}/{id}";
            var result = await url.DeleteAsync();
            return (T)result;


        }
    }
}
