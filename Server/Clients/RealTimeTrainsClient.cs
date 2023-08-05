using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Server.Clients
{
    public class RealTimeTrainsClient : IRailClient
    {
        AppConfiguration _config;
        public RealTimeTrainsClient(AppConfiguration config)
        {
            this._config = config;
        }

        public async Task<string> GetSimpleDepartureBoard(string location)
        {
            /*using var railClient = new HttpClient
            {
                //BaseAddress = new Uri($"https://{_config.ApiUsername}:{_config.ApiPassword}@api.rtt.io/api/v1/json/")
                
            };*/

            HttpClient railClient = new HttpClient();
            string contentTypeValue = "application/json";

            railClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", contentTypeValue);
            var byteArray = Encoding.ASCII.GetBytes($"{_config.ApiUsername}:{_config.ApiPassword}");
            railClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            var querystring = $"https://api.rtt.io/api/v1/json/search/{location}";
            Console.WriteLine(querystring);

            var response    = await railClient.GetAsync(querystring);
            var content = "";
            if (response.IsSuccessStatusCode)
            {
                //var content = await response.Content.ReadAsStringAsync();
                content =  await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new ArgumentException("request was not successful");
            }
            return content;
        }
    }
}

public interface IRailClient
{
    Task<string?> GetSimpleDepartureBoard(string location);
}