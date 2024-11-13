using Microsoft.CodeAnalysis.Scripting;
using System.Collections.Generic;

namespace JoresDuona.Services
{
    public class UserSessionService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private int? _currentUserId;

        public UserSessionService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public int? GetCurrentUserId() => _currentUserId;

        public void SetCurrentUser(int userId) => _currentUserId = userId;

        public async Task<bool> AuthenticateUser(string username, string password)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("StudyBuddy.API");
            var response = await httpClient.GetAsync($"api/v1/user/by-username/{username}");

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            int? user = await response.Content.ReadFromJsonAsync<int>();
            //if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            if (user == null)
            {
                return false;
            }

            //  SetCurrentUser(user);
            return true;
        }
    }
}
