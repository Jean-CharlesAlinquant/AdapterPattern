
using System.Text.Json;

namespace DesignPatterns.Adapter;

public class JsonParser<T> : IJsonParser<T>
{
    public T? Parse(string data)
    {
        return JsonSerializer.Deserialize<T>(data);
    }

    public string ConvertToJson(T obj)
    {
        return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
    }
}