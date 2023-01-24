﻿using eRent.Models;
using Flurl.Http;

namespace eRent.UI
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = "https://localhost:7007/";

        public static string username = null;
        public static string password = null;

        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> Get<T>(object search = null)
        {
            var query = "";
            if (search != null)
            {
                query = await search.ToQueryString();
            }
            var list =
                await $"{_endpoint}{_resource}?{query}".WithBasicAuth(username, password).GetJsonAsync<T>();
            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var result =
                await $"{_endpoint}{_resource}/{id}".WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Post<T>(object request)
        {
            var result =
                await $"{_endpoint}{_resource}".WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Put<T>(object id, object request)
        {
            var result =
                await $"{_endpoint}{_resource}/{id}".WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
