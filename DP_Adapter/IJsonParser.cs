namespace DesignPatterns.Adapter;

// Target -> The interface the client wants to use
public interface IJsonParser<T>
{
    T? Parse(string data);
    string ConvertToJson(T obj);
}
