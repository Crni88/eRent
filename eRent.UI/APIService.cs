using Flurl.Http;

namespace eRent.UI
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = "https://localhost:7007/";
        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> Get<T>()
        {
            var list = await $"{_endpoint}{_resource}".GetJsonAsync<T>();
            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Post<T>(object request)
        {
            var result = await $"{_endpoint}{_resource}".PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Put<T>(object request, object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
