using System.Text.Json;
using System.Text;

public class OllamaService
{
    private readonly HttpClient _httpClient;
    private readonly string _ollamaUrl;

    public OllamaService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _ollamaUrl = configuration["OllamaUrl"]!;
    }

    public async Task<string> GetResponseFromOllama(string userInput)
    {
        var requestBody = new
        {
            model = "mistral", // or llama2, tinyllama, etc.
            prompt = userInput,
            stream = false // use true for streaming later
        };

        var response = await _httpClient.PostAsJsonAsync(_ollamaUrl, requestBody);
        response.EnsureSuccessStatusCode();

        var responseJson = await response.Content.ReadFromJsonAsync<JsonElement>();
        return responseJson.GetProperty("response").GetString();
    }

    public async IAsyncEnumerable<string> StreamResponseFromOllama(string prompt)
    {
        var body = new
        {
            model = "mistral",
            prompt,
            temperature= 0.2,
            stream = true
        };

        var request = new HttpRequestMessage(HttpMethod.Post, _ollamaUrl)
        {
            Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
        };

        var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

        response.EnsureSuccessStatusCode();

        using var stream = await response.Content.ReadAsStreamAsync();
        using var reader = new StreamReader(stream);

        while (!reader.EndOfStream)
        {
            var line = await reader.ReadLineAsync();
            if (!string.IsNullOrWhiteSpace(line) && line.StartsWith("{"))
            {
                var json = JsonSerializer.Deserialize<JsonElement>(line);
                var token = json.GetProperty("response").GetString();
                if (!string.IsNullOrEmpty(token))
                    yield return token;
            }
        }
    }
}
