using PH_MarvelApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PH_MarvelApp.Services
{
    public class UserService : Service
    {
        public async Task<User> AddUserAsync(User user)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync($"{BaseApiUrl}/api/v1/usuarios", user);

            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            else
            {
                user = null;
            }

            return user;
        }
    }
}
