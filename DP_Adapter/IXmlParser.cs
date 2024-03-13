
namespace DesignPatterns.Adapter;

// Adaptee -> The interface that is incompatible with the Target interface
public interface IXmlParser<T>
{
    T? Parse(string data);
    string ConvertToXml(T obj);
}
