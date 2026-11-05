using System.Text;

namespace MauiBasicAuth.DataAccess
{
    public class UserAuthentication
    {
        public bool AuthenticateUser(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5255/"); // Match your Web API port
                var authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authToken);

                var response = client.GetAsync("api/values").Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}