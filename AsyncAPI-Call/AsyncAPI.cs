using System;
using System.Net.Http;
using System.Threading.Tasks;

class AsyncAPI
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching data from the API...");
        await FetchDataAsync();
        Console.WriteLine("Finished fetching data.");
    }

    static async Task FetchDataAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            // Example: Fetching data from a public API (replace with a real API URL)
            string apiUrl = "https://api.coindesk.com/v1/bpi/currentprice.json";

            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throw if not a success code

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {responseBody}\n\n");
                // Console.WriteLine($"Response: {responseBody.disclaimer}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}
