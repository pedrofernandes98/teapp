using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PH_MarvelApp.Services
{
    public class Service
    {
        protected HttpClient _client;
        protected string BaseApiUrl = "https://teapp-api-netcore.azurewebsites.net/";
    }
}
